using Dto;
using Dto.Extensions;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Presenters;

public class CreateUserPresenter : IUseCaseOutputPort<CreateUserRequestDto>
{
    private readonly ILogger<CreateUserPresenter> _logger;
    private GenericHttpResponse? _response;
    private string? _responseMessage;
    private int? _responseStatusCode;
    private object? _responseData;

    public CreateUserPresenter(ILogger<CreateUserPresenter> logger) => (_logger) = (logger);

    public Task<GenericHttpResponse> Handle(User inputData)
    {
        _responseMessage = "User Created.";
        _responseStatusCode = 202;
        _responseData = inputData.ToUserResponseDto();

        _response = new GenericHttpResponse()
        {
            Message = _responseMessage,
            StatusCode = _responseStatusCode,
            Data = _responseData
        };

        return Task.FromResult(_response);
    }
}
