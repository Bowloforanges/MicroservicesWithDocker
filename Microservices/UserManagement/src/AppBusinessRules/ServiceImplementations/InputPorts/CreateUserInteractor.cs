using Dto;
using Dto.Extensions;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace ServiceImplementations.InputPorts;

public class CreateUserInteractor : IUseCaseInputPort<CreateUserRequestDto>
{
    private readonly ILogger<CreateUserInteractor> _logger;
    private readonly ICreationRepository<User> _repository;
    private readonly IUnitOfWork<User> _unitOfWork;
    private readonly IUseCaseOutputPort<User> _outputPort;

    public CreateUserInteractor(
        ILogger<CreateUserInteractor> logger,
        ICreationRepository<User> repository,
        IUnitOfWork<User> unitOfWork,
        IUseCaseOutputPort<User> outputPort
    ) =>
        (_logger, _repository, _unitOfWork, _outputPort) = (
            logger,
            repository,
            unitOfWork,
            outputPort
        );

    public async Task<GenericHttpResponse> Handle(CreateUserRequestDto inputData)
    {
        User userData = inputData.ToUser();

        var result = await _repository.Create(userData);
        //_unitOfWork.Commit();

        return await _outputPort.Handle(result);
        ;
    }
}
