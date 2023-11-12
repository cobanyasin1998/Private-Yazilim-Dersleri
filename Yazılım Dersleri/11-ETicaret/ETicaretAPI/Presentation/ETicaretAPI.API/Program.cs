using ETicaretAPI.API.Configurations.Log.ColumnWriters;
using ETicaretAPI.API.Extensions;
using ETicaretAPI.Application;
using ETicaretAPI.Application.Validators.Products;
using ETicaretAPI.Infrastructure;
using ETicaretAPI.Infrastructure.Filters;
using ETicaretAPI.Infrastructure.Services.Storage.Azure;
using ETicaretAPI.Persistence;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.PostgreSQL;
using System.Security.Claims;
using System.Text;
using ETicaretAPI.SignalR;
using ETicaretAPI.SignalR.Hubs;
using ETicaretAPI.Infrastructure.Services.Storage.Local;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(opt =>
{
    opt.Filters.Add<ValidationFilter>();
})
    .AddFluentValidation(conf =>
    {
        conf.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>();
    })
    .ConfigureApiBehaviorOptions(conf =>
    {
        conf.SuppressModelStateInvalidFilter = true;
    });

builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
        //policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt")
    .WriteTo.PostgreSQL(builder.Configuration.GetConnectionString("PostgreSQL"), "logs", needAutoCreateTable: true, restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Verbose,
        columnOptions: new Dictionary<string, ColumnWriterBase>
        {
            { "message",new RenderedMessageColumnWriter() },
            { "message_template",new MessageTemplateColumnWriter() },
            { "level",new LevelColumnWriter() },
            { "time_stamp",new TimestampColumnWriter() },
            { "exception",new ExceptionColumnWriter() },
            { "log_event",new LogEventSerializedColumnWriter() },
            { "user_name", new UsernameColumnWriter()}
        },
        schemaName: "public")
    .WriteTo.Seq(builder.Configuration["Seq:ServerURL"])
    .MinimumLevel.Information()
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;

});





builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();
builder.Services.AddSignalRServices();

builder.Services.AddStorage<LocalStorage>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer("Admin", opt =>
{
    opt.TokenValidationParameters = new()
    {
        ValidateIssuer = true,           //Oluþturulacak token deðerini kimlerin/ hangi originlerin/sitelerin kullanýcý belirlediðimiz deðerdir.
        ValidateAudience = true,         //Oluþturulacak token deðerinin kimin daðýttýðýný ifade edeceðimiz alandýr
        ValidateLifetime = true,         //Oluþturulacak token deðerinin süresini kontrol edecek olan doðrulamadýr.
        ValidateIssuerSigningKey = true, //Üretilecek token deðerinin uygulamamýza ait bir deðer olduðunu security key verisinin doðrulanmasýdýr.
        ValidAudience = builder.Configuration["Token:Audience"],
        LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false,
        ValidIssuer = builder.Configuration["Token:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
        NameClaimType = ClaimTypes.Name
    };
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());
app.UseStaticFiles();
app.UseSerilogRequestLogging();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    var username = context.User?.Identity?.IsAuthenticated != null ? context.User.Identity.Name : null;
    LogContext.PushProperty("user_name", username);
    await next();
});

app.MapControllers();

app.MapHubs();
app.Run();
