using Dto.Abstractions;

namespace Dto;

public class GetUserRequestDto : DtoBase
{
    public Guid Guid { get; init; }
}
