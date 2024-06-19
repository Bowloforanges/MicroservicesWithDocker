using Dto;
using Dto.Extensions;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Presenters;

public class UserPresenter : IUseCaseOutputPort<User>
{
    private readonly ILogger<UserPresenter> _logger;
    private GenericHttpResponse? _response;
    private string? _responseMessage;
    private int? _responseStatusCode;
    private object? _responseData;

    public UserPresenter(ILogger<UserPresenter> logger) => (_logger) = (logger);

    public Task<GenericHttpResponse> Handle(User inputData)
    {
        _responseMessage = "Request completed.";
        _responseStatusCode = 200;
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
