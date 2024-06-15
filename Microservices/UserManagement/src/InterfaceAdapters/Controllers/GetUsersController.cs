using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class GetUsersController : ControllerBase
{
    [HttpGet("users")]
    public async Task<IActionResult> GetAllUsers()
    {
        Console.WriteLine("This is a list of users");
        await Task.Delay(1);

        return Ok();
    }
}
