using Dtos;
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
    //UseAuthorization
    public async Task<IActionResult> GetAllUsers()
    {
        await Task.Delay(1);
        _logger.LogInformation("All users.");

        //get from db, implement pagination

        List<UserListElementResponseDto> responseData = new List<UserListElementResponseDto>();

        GenericHttpResponse response = new GenericHttpResponse()
        {
            Message = "",
            StatusCode = 200,
            Data = responseData
        };
        return Ok(response);
    }
}
