using Controllers.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InversionOfControl;

public static class DependencyContainer
{
    public static IServiceCollection AddDependencies(
        this IServiceCollection services,
        IConfigurationRoot configuration,
        bool isDevelopment,
        bool isNotContainer
    )
    {
        services.AddUserManagementControllers();

        return services;
    }
}
