using DTO;
using DTO.Extensions;
using Entities;
using Microsoft.AspNetCore.Authorization;
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
    [AllowAnonymous]
    //UseAuthorization
    public async Task<IActionResult> CreateUser(CreateUserRequestDTO createUserRequest)
    {
        await Task.Delay(1);

        _logger.LogInformation("User created.");

        User user = createUserRequest.ToUser();

        //store here

        //generate response here
        var responseData = user.ToUserResponseDTO();

        GenericHttpResponse response = new GenericHttpResponse()
        {
            Message = "User created.",
            StatusCode = 201,
            Data = responseData
        };

        return Ok(response);
    }
}
