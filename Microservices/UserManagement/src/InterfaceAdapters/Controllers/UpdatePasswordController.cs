using Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class UpdatePasswordController : ControllerBase
{
    private readonly ILogger<UpdatePasswordController> _logger;
    private readonly IUseCaseInputPort<UpdatePasswordRequestDto> _interactor;

    public UpdatePasswordController(
        ILogger<UpdatePasswordController> logger,
        IUseCaseInputPort<UpdatePasswordRequestDto> interactor
    ) => (_logger, _interactor) = (logger, interactor);

    [HttpPut("users/change-password")]
    public async Task<IActionResult> UpdatePassword(UpdatePasswordRequestDto request)
    {
        _logger.LogInformation("User password was updated.");

        var result = await _interactor.Handle(request);

        return Ok(result);
    }
}
