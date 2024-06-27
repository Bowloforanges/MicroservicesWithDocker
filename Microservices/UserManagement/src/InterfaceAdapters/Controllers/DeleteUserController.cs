using Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class DeleteUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;

    private readonly IUseCaseInputPort<DeleteUserRequestDto> _interactor;

    public DeleteUserController(
        ILogger<GetUserController> logger,
        IUseCaseInputPort<DeleteUserRequestDto> interactor
    ) => (_logger, _interactor) = (logger, interactor);

    [HttpDelete("users")]
    //UseAuthorization
    public async Task<IActionResult> DeleteUser(DeleteUserRequestDto userToDelete)
    {
        _logger.LogInformation("Deleted user.");

        var result = await _interactor.Handle(userToDelete);

        return Ok(result);
    }
}
