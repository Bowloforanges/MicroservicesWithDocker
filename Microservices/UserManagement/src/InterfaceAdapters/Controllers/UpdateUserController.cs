using Dto;
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
    public async Task<IActionResult> UpdateUser(UpdateUserRequestDto userToUpdate)
    {
        await Task.Delay(1);

        _logger.LogInformation($"Updated user.");

        // update user data

        UserResponseDto responseData = new UserResponseDto()
        {
            Username = userToUpdate.Username,
            Email = userToUpdate.Email,
            CreatedAt = DateTime.Now
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
