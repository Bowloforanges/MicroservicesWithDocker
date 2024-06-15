using DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class CreateUserController : ControllerBase
{
    [HttpPost("users")]
    public async Task<IActionResult> CreateUser(CreateUserRequestDTO createUserRequest)
    {
        Console.WriteLine($"User created: {createUserRequest.Name}");
        await Task.Delay(1);

        GenericHttpResponse response = new GenericHttpResponse();
        return Ok(response);
    }
}
