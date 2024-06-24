using Dto;
using Dto.Extensions;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class UpdateUserInteractor : IUseCaseInputPort<UpdateUserRequestDto>
{
    private readonly ILogger<GetUserInteractor> _logger;
    private readonly IUpdateRepository<User> _repository;
    private readonly IUseCaseOutputPort<User> _outputPort;

    public UpdateUserInteractor(
        ILogger<GetUserInteractor> logger,
        IUpdateRepository<User> repository,
        IUseCaseOutputPort<User> outputPort
    ) => (_logger, _repository, _outputPort) = (logger, repository, outputPort);

    public async Task<GenericHttpResponse> Handle(UpdateUserRequestDto inputData)
    {
        User userData = inputData.ToUser();

        User updatedUser = await _repository.Update(userData);

        return await _outputPort.Handle(updatedUser);
    }
}
