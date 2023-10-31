using ETicaretAPI.Application.Validators.Products;
using ETicaretAPI.Infrastructure.Filters;
using ETicaretAPI.Persistence;
using ETicaretAPI.Infrastructure;
using FluentValidation.AspNetCore;
using System.Data.SqlTypes;
using ETicaretAPI.Infrastructure.Services.Storage.Local;
using ETicaretAPI.Infrastructure.Services.Storage.Azure;
using ETicaretAPI.Application;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
        policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        //policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();


builder.Services.AddStorage<AzureStorage>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer("Admin",opt =>
{
    opt.TokenValidationParameters = new()
    {
        ValidateIssuer = true,           //Olu�turulacak token de�erini kimlerin/ hangi originlerin/sitelerin kullan�c� belirledi�imiz de�erdir.
        ValidateAudience = true,         //Olu�turulacak token de�erinin kimin da��tt���n� ifade edece�imiz aland�r
        ValidateLifetime = true,         //Olu�turulacak token de�erinin s�resini kontrol edecek olan do�rulamad�r.
        ValidateIssuerSigningKey = true, //�retilecek token de�erinin uygulamam�za ait bir de�er oldu�unu security key verisinin do�rulanmas�d�r.

        ValidAudience = builder.Configuration["Token:Audience"],
        ValidIssuer = builder.Configuration["Token:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
    };
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
