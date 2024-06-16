using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class UpdateUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;

    public UpdateUserController(ILogger<GetUserController> logger) => (_logger) = (logger);

    [HttpPut("users/{userId}")]
    //UseAuthorization
    public async Task<IActionResult> UpdateUser(Guid userId)
    {
        await Task.Delay(1);

        _logger.LogInformation($"{GetType().Name} - Updated user with id {userId}");

        GenericHttpResponse response = new GenericHttpResponse() { Message = "", StatusCode = 200 };
        return Ok(response);
    }
}
