using System.Reflection;
using InversionOfControl;
using UserManagementApi.Extensions;

// Set environment type and config file base path.
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
string? basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

// Add json settings.
var configuration = new ConfigurationBuilder()
    .SetBasePath(basePath ?? "")
    .AddJsonFile("appsettings.json", optional: true)
    .AddJsonFile($"appsettings.{environment}.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

var builder = WebApplication.CreateBuilder(args);
var isDevelopment = builder.Environment.IsDevelopment();
var runtime = configuration.RuntimeEnvironment();

// Add services to the container.
builder.Services.AddDependencies(configuration, isDevelopment, runtime);

if (isDevelopment)
{
    builder.Services.AddSwaggerGen();
}
else
{
    // Productive config goes here.
}

builder.AddLogger(isDevelopment);

var app = builder.Build();

app.Configure();

app.Run();
