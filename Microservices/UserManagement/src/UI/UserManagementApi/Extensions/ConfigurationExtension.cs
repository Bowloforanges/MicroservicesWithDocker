using Microsoft.AspNetCore.Cors.Infrastructure;
using Serilog;
using Serilog.Events;

namespace UserManagementApi.Extensions;

public static class ConfigurationExtensions
{
    public static bool RuntimeEnvironment(this IConfiguration configuration)
    {
        return configuration.GetValue("IS_CONTAINERIZED", false);
    }

    public static IApplicationBuilder Configure(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        //app.UseMiddleware<MIDDLEWARECLASS>();

        //app.UseAuthentication();
        //app.UseAuthorization();
        app.UseHttpsRedirection();
        app.UseCors("AllowAllOrigins");
        app.MapControllers();

        return app;
    }

    public static WebApplicationBuilder AddCors(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(options =>
        {
            options.AddPolicy(
                "AllowAllOrigins",
                corsPolicyBuilder =>
                {
                    corsPolicyBuilder.AllowAnyOrigin();
                    corsPolicyBuilder.AllowAnyHeader();
                    corsPolicyBuilder.AllowAnyMethod();
                }
            );
        });
        return builder;
    }

    public static WebApplicationBuilder AddLogger(
        this WebApplicationBuilder builder,
        bool isDevelopment
    )
    {
        var loggerConfiguration = new LoggerConfiguration().WriteTo.Console();

        if (!isDevelopment)
        {
            /*loggerConfiguration.WriteTo.File(
                //Set location with a string
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 4,
                fileSizeLimitBytes: 10 * 1024 * 1024 //10MB
            );*/
        }

        Log.Logger = loggerConfiguration.CreateLogger();
        builder.Host.UseSerilog();

        return builder;
    }
}
