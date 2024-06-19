using Dto;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using ServiceInterfaces;

namespace Presenters.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<IUseCaseOutputPort<User>, UserPresenter>();
        services.AddScoped<IUseCaseOutputPort<List<User>>, UsersPresenter>();

        return services;
    }
}
