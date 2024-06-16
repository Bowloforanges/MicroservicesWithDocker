using Microsoft.Extensions.DependencyInjection;

namespace Controllers.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddUserManagementControllers(this IServiceCollection services)
    {
        services.AddControllers().AddApplicationPart(typeof(DependencyContainer).Assembly);

        return services;
    }
}
