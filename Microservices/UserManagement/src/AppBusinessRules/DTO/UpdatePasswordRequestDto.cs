using Dto.Abstractions;

namespace Dto;

public class UpdatePasswordRequestDto : DtoBase
{
    public Guid Guid { get; set; }
    public string? OldPassword { get; init; }
    public string? NewPassword { get; init; }
}
