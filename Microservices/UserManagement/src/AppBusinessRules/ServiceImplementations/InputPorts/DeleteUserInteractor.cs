using Dto;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class DeleteUserInteractor : IUseCaseInputPort<DeleteUserRequestDto>
{
    private readonly ILogger<DeleteUserInteractor> _logger;
    private readonly IUseCaseOutputPort<User> _outputPort;
    private readonly IDeletionRepository<User> _repository;

    public DeleteUserInteractor(
        ILogger<DeleteUserInteractor> logger,
        IUseCaseOutputPort<User> outputPort,
        IDeletionRepository<User> repository
    ) => (_logger, _outputPort, _repository) = (logger, outputPort, repository);

    public async Task<GenericHttpResponse> Handle(DeleteUserRequestDto inputData)
    {
        User deletedUser = await _repository.Delete(inputData.Guid);

        return await _outputPort.Handle(deletedUser);
    }
}
