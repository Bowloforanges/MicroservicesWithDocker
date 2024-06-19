using Dto;
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

        _logger.LogInformation($"User with userId: {userId}");

        //get user from DB

        UserResponseDto responseData = new UserResponseDto()
        {
            Username = "dummy_username",
            Email = "dummy@email.com",
            CreatedAt = DateTime.UtcNow
        };

        GenericHttpResponse response = new GenericHttpResponse()
        {
            Message = "",
            StatusCode = 200,
            Data = responseData
        };

        return Ok(response);
    }
}
