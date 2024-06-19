using Dto.Abstractions;

namespace Dto;

public class CreateUserRequestDto : DtoBase
{
    public string? Username { get; init; }
    public string? Email { get; init; }
    public string? Password { get; init; }
}
