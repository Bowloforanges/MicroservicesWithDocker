using Dto;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class GetAllUsersInteractor : IUseCaseInputPort<GetAllUsersRequestDto>
{
    private readonly ILogger<CreateUserInteractor> _logger;
    private readonly IRetrievalRepository<User> _repository;
    private readonly IUseCaseOutputPort<List<User>> _outputPort;

    public GetAllUsersInteractor(
        ILogger<CreateUserInteractor> logger,
        IRetrievalRepository<User> repository,
        IUseCaseOutputPort<List<User>> outputPort
    ) => (_logger, _repository, _outputPort) = (logger, repository, outputPort);

    public async Task<GenericHttpResponse> Handle(GetAllUsersRequestDto inputData)
    {
        List<User> usersData = await _repository.GetAllUsers();

        return await _outputPort.Handle(usersData);
    }
}
