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

    [HttpGet("users/{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        await Task.Delay(1);

        _logger.LogInformation($"{GetType().Name} - User with userId: {id}");

        GenericHttpResponse response = new GenericHttpResponse();
        return Ok(response);
    }
}
