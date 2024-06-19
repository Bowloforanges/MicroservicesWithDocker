using Dto;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class GetUserInteractor : IUseCaseInputPort<GetUserRequestDto>
{
    private readonly ILogger<GetUserInteractor> _logger;
    private readonly IRetrievalRepository<User> _repository;
    private readonly IUseCaseOutputPort<User> _outputPort;

    public GetUserInteractor(
        ILogger<GetUserInteractor> logger,
        IRetrievalRepository<User> repository,
        IUseCaseOutputPort<User> outputPort
    ) => (_logger, _repository, _outputPort) = (logger, repository, outputPort);

    public async Task<GenericHttpResponse> Handle(GetUserRequestDto inputData)
    {
        User userData = await _repository.GetUserById(inputData.Guid);

        return await _outputPort.Handle(userData);
    }
}
