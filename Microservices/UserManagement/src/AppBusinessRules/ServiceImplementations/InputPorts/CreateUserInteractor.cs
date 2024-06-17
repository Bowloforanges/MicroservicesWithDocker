using Dto;
using Dto.Extensions;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class CreateUserInteractor : IUseCaseInputPort<CreateUserInteractor, CreateUserRequestDto>
{
    private readonly ILogger<CreateUserInteractor> _logger;
    private readonly ICreationRepository<CreateUserRequestDto> _repository;
    private readonly IUnitOfWork<User> _unitOfWork;
    private readonly IUseCaseOutputPort<CreateUserRequestDto> _outputPort;

    public CreateUserInteractor(
        ILogger<CreateUserInteractor> logger,
        ICreationRepository<CreateUserRequestDto> repository,
        IUnitOfWork<User> unitOfWork,
        IUseCaseOutputPort<CreateUserRequestDto> outputPort
    ) =>
        (_logger, _repository, _unitOfWork, _outputPort) = (
            logger,
            repository,
            unitOfWork,
            outputPort
        );

    public async Task Handle(CreateUserRequestDto inputData)
    {
        var result = await _repository.Create(inputData);

        //commit

        var outputData = _outputPort.Handle(result);

        await Task.CompletedTask;
    }
}
