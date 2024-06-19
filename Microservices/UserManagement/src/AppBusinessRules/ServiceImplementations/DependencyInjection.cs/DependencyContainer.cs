using Dto;
using Microsoft.Extensions.DependencyInjection;
using ServiceImplementations.InputPorts;
using ServiceInterfaces;

namespace ServiceImplementations.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddPorts(this IServiceCollection services)
    {
        services.AddScoped<IUseCaseInputPort<CreateUserRequestDto>, CreateUserInteractor>();
        services.AddScoped<IUseCaseInputPort<GetUserRequestDto>, GetUserInteractor>();
        services.AddScoped<IUseCaseInputPort<GetAllUsersRequestDto>, GetAllUsersInteractor>();

        return services;
    }
}
