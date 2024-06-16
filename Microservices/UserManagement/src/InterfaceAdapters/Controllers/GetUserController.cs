using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class GetUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;

    public GetUserController(ILogger<GetUserController> logger) => (_logger) = (logger);

    [HttpGet("users/{userId}")]
    //UseAuthorization
    public async Task<IActionResult> GetUserById(Guid userId)
    {
        await Task.Delay(1);

        _logger.LogInformation($"{GetType().Name} - User with userId: {userId}");

        GenericHttpResponse response = new GenericHttpResponse() { Message = "", StatusCode = 200 };
        return Ok(response);
    }
}
