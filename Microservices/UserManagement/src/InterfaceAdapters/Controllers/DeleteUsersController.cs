using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class DeleteUsersController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;

    public DeleteUsersController(ILogger<GetUserController> logger) => (_logger) = (logger);

    [HttpDelete("users/{userId}")]
    //UseAuthorization
    public async Task<IActionResult> DeleteUser(Guid userId)
    {
        await Task.Delay(1);

        _logger.LogInformation($"{GetType().Name} - Deleted user with id {userId}");

        GenericHttpResponse response = new GenericHttpResponse() { Message = "", StatusCode = 200 };
        return Ok(response);
    }
}
