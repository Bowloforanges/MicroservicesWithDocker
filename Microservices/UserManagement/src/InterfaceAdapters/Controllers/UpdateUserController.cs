using Dto;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class UpdateUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;
    private readonly IUseCaseInputPort<UpdateUserRequestDto> _interactor;

    public UpdateUserController(
        ILogger<GetUserController> logger,
        IUseCaseInputPort<UpdateUserRequestDto> interactor
    ) => (_logger, _interactor) = (logger, interactor);

    [HttpPut("users")]
    //UseAuthorization
    public async Task<IActionResult> UpdateUser(UpdateUserRequestDto userToUpdate)
    {
        await Task.Delay(1);

        _logger.LogInformation($"Updated user.");

        // update user data
        var result = await _interactor.Handle(userToUpdate);

        return Ok(result);
    }
}
