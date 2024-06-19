using Dto;
using Microsoft.Extensions.DependencyInjection;
using ServiceInterfaces;

namespace Presenters.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<IUseCaseOutputPort<CreateUserRequestDto>, CreateUserPresenter>();

        return services;
    }
}
