using Dto.Abstractions;

namespace Dto;

public class DeleteUserRequestDto : DtoBase
{
    public Guid Guid { get; init; }
}
