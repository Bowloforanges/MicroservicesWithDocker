using System.ComponentModel.DataAnnotations;

namespace Entities.Abstractions;

public abstract class EntityBase
{
    [Required]
    public Guid Guid { get; init; }
}
