using BusinessLogic;
using Database;
using Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddDbContext<SQLLiteContex>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IProjectController, ProjectController>();
builder.Services.AddSingleton<IImageController, ImageContoller>();
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var app = builder.Build();
app.MapStaticAssets().ShortCircuit();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Welcome\non my portfolio server.";
}).WithName("Home");

ImageEndpoints.Map(app);
ProjectEndpoints.Map(app);

app.Run();
