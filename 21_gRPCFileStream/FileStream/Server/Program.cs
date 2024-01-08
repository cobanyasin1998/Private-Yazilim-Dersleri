using Server.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();
app.UseStaticFiles();
app.MapGrpcService<FileTransportService>();
app.MapGet("/", () => " ");

app.Run();
