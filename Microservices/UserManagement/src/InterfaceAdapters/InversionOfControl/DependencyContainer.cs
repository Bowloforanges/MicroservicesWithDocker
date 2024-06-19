using Controllers.DependencyInjection;
using EFCore.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presenters.DependencyInjection;
using ServiceImplementations.DependencyInjection;

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
        services.AddPorts();
        services.AddUserManagementControllers();
        services.AddEFCore();
        services.AddPresenters();

        return services;
    }
}
