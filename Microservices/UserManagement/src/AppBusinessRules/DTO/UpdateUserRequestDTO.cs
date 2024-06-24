using Dto.Abstractions;

namespace Dto;

public class UpdateUserRequestDto : DtoBase
{
    public Guid Guid { get; init; }
    public string? Username { get; init; }
    public string? Email { get; init; }
}
