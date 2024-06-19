using EFCore.Repositories;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using ServiceInterfaces;

namespace EFCore.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddEFCore(this IServiceCollection services)
    {
        services.AddScoped<ICreationRepository<User>, CreateUserRepository>();
        services.AddSingleton<IUnitOfWork<User>, UserUnitOfWork>();

        return services;
    }
}
