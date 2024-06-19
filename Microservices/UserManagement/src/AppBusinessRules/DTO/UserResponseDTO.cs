using Dto.Abstractions;

namespace Dto;

public class UserResponseDto : DtoBase
{
    public string? Username { get; init; }
    public string? Email { get; init; }
    public DateTime? CreatedAt { get; init; }
}
