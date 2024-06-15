using DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class CreateUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;

    public CreateUserController(ILogger<GetUserController> logger) => (_logger) = (logger);

    [HttpPost("users")]
    public async Task<IActionResult> CreateUser(CreateUserRequestDTO createUserRequest)
    {
        await Task.Delay(1);

        _logger.LogInformation($"{GetType().Name} - User created: {createUserRequest.Name}");

        GenericHttpResponse response = new GenericHttpResponse();
        return Ok(response);
    }
}
