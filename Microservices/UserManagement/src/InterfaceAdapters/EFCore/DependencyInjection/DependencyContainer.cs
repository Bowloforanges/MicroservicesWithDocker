using Dto;
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
        services.AddScoped<IRetrievalRepository<User>, UserRetrievalRepository>();
        services.AddScoped<IUpdateRepository<User>, UpdateUserRepository>();
        services.AddScoped<IDeletionRepository<User>, UserDeletionRepository>();
        services.AddSingleton<IUnitOfWork<User>, UserUnitOfWork>();

        return services;
    }
}
