using Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceInterfaces.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddPorts(this IServiceCollection services)
    {
        services.AddScoped<ICreationRepository<User>, CreateUserRepository>();
        return services;
    }
}
