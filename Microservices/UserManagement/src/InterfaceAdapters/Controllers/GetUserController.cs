using Dtos;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceInterfaces;

namespace Controllers;

[ApiController]
[Route("api/v1")]
public class GetUserController : ControllerBase
{
    private readonly ILogger<GetUserController> _logger;
    private readonly IUseCaseInputPort<GetUserRequestDto> _interactor;

    public GetUserController(
        ILogger<GetUserController> logger,
        IUseCaseInputPort<GetUserRequestDto> interactor
    ) => (_logger, _interactor) = (logger, interactor);

    [HttpGet("users/{guid}")]
    //UseAuthorization
    public async Task<IActionResult> GetUserById([FromRoute] Guid guid)
    {
        await Task.Delay(1);

        _logger.LogInformation($"User with userId: {guid}");

        var result = await _interactor.Handle(new GetUserRequestDto { Guid = guid });

        return Ok(result);
    }
}
