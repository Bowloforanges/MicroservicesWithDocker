using System.ComponentModel.DataAnnotations;

namespace Entities.Abstractions;

public abstract class EntityBase
{
    [Required]
    [Key]
    public Guid Guid { get; init; }
}
