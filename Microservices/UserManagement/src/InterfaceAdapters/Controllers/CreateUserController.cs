using DTO;
using DTO.Extensions;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Utils;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class CreateUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;

    public CreateUserController(ILogger<GetUserController> logger) => (_logger) = (logger);

    [HttpPost("users")]
    //UseAuthorization
    public async Task<IActionResult> CreateUser(CreateUserRequestDTO createUserRequest)
    {
        await Task.Delay(1);

        _logger.LogInformation($"{GetType().Name} - User created: {createUserRequest.Username}");

        User user = createUserRequest.ToUser();

        GenericHttpResponse response = new GenericHttpResponse()
        {
            Message = $"User: {ObjectPrinter.Print(user)} created.",
            StatusCode = 201
        };
        return Ok(response);
    }
}
