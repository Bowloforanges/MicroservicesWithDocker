using Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class CreateUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;
    private readonly IUseCaseInputPort<CreateUserRequestDto> _interactor;

    public CreateUserController(
        ILogger<GetUserController> logger,
        IUseCaseInputPort<CreateUserRequestDto> interactor
    ) => (_logger, _interactor) = (logger, interactor);

    [HttpPost("users")]
    [AllowAnonymous]
    //UseAuthorization
    public async Task<IActionResult> CreateUser(CreateUserRequestDto createUserRequest)
    {
        _logger.LogInformation("User created.");

        //store here
        var result = await _interactor.Handle(createUserRequest);

        return Ok(result);
    }
}
