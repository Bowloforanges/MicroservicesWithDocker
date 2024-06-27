using Dto;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class UpdatePasswordInteractor : IUseCaseInputPort<UpdatePasswordRequestDto>
{
    private readonly ILogger<UpdatePasswordInteractor> _logger;
    private readonly IPasswordRepository<User> _repository;
    private readonly IUseCaseOutputPort<User> _outputPort;

    public UpdatePasswordInteractor(
        ILogger<UpdatePasswordInteractor> logger,
        IPasswordRepository<User> repository,
        IUseCaseOutputPort<User> outputPort
    ) => (_logger, _repository, _outputPort) = (logger, repository, outputPort);

    public async Task<GenericHttpResponse> Handle(UpdatePasswordRequestDto inputData)
    {
        User updatedUser = await _repository.UpdatePassword(inputData);

        return await _outputPort.Handle(updatedUser);
    }
}
