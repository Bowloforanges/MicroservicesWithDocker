using Dtos;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class GetUserInteractor : IUseCaseInputPort<GetUserRequestDto>
{
    private readonly ILogger<GetUserInteractor> _logger;
    private readonly IRetrievalRepository<User> _repository;
    private readonly IUnitOfWork<User> _unitOfWork;
    private readonly IUseCaseOutputPort<GetUserRequestDto> _outputPort;

    public GetUserInteractor(
        ILogger<GetUserInteractor> logger,
        IRetrievalRepository<User> repository,
        IUnitOfWork<User> unitOfWork,
        IUseCaseOutputPort<GetUserRequestDto> outputPort
    ) =>
        (_logger, _repository, _unitOfWork, _outputPort) = (
            logger,
            repository,
            unitOfWork,
            outputPort
        );

    public async Task<GenericHttpResponse> Handle(GetUserRequestDto inputData)
    {
        User userData = await _repository.GetUserById(inputData.Guid);

        return await _outputPort.Handle(userData);
    }
}
