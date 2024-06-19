using Dto;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class GetUsersController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;
    private readonly IUseCaseInputPort<GetAllUsersRequestDto> _interactor;

    public GetUsersController(
        ILogger<GetUserController> logger,
        IUseCaseInputPort<GetAllUsersRequestDto> interactor
    ) => (_logger, _interactor) = (logger, interactor);

    [HttpGet("users")]
    //UseAuthorization
    public async Task<IActionResult> GetAllUsers()
    {
        await Task.Delay(1);
        _logger.LogInformation("All users.");

        //get from db, implement pagination
        var result = await _interactor.Handle(new GetAllUsersRequestDto());

        return Ok(result);
    }
}
