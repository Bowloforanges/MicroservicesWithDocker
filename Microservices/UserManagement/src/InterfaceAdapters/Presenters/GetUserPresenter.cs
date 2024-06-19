using Dtos;
using Dtos.Extensions;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Presenters;

public class GetUserPresenter : IUseCaseOutputPort<GetUserRequestDto>
{
    private readonly ILogger<GetUserPresenter> _logger;
    private GenericHttpResponse? _response;
    private string? _responseMessage;
    private int? _responseStatusCode;
    private object? _responseData;

    public Task<GenericHttpResponse> Handle(User inputData)
    {
        _responseMessage = "User Fetched.";
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
