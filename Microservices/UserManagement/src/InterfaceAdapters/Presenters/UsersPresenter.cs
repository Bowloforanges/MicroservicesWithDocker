using Dto;
using Dto.Extensions;
using Entities;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Presenters;

public class UsersPresenter : IUseCaseOutputPort<List<User>>
{
    private readonly ILogger<UsersPresenter> _logger;
    private GenericHttpResponse? _response;
    private string? _responseMessage;
    private int? _responseStatusCode;
    private object? _responseData;

    public UsersPresenter(ILogger<UsersPresenter> logger) => (_logger) = (logger);

    public Task<GenericHttpResponse> Handle(List<User> inputData)
    {
        _responseMessage = "Request Completed.";
        _responseStatusCode = 200;
        _responseData = inputData.ToUserListElementDTO();

        _response = new GenericHttpResponse()
        {
            Message = _responseMessage,
            StatusCode = _responseStatusCode,
            Data = _responseData
        };

        return Task.FromResult(_response);
    }
}
