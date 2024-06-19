using Dtos.Abstractions;

namespace Dtos;

public class GetUserRequestDto : DtoBase
{
    public Guid Guid { get; init; }
}
