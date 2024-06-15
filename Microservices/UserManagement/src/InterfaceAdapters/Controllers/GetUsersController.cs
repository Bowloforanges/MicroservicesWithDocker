using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class GetUsersController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;

    public GetUsersController(ILogger<GetUserController> logger) => (_logger) = (logger);

    [HttpGet("users")]
    public async Task<IActionResult> GetAllUsers()
    {
        await Task.Delay(1);
        _logger.LogInformation(
            $"{GetType().Name} - This is a list of users: [user1, user2, user3, ..., userN]"
        );

        GenericHttpResponse response = new GenericHttpResponse();
        return Ok(response);
    }
}
