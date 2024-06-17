using System.ComponentModel.DataAnnotations;
using Entities.Abstractions;
using Entities.DataAnnotations;

namespace Entities;

public class User : EntityBase
{
    [Required]
    [MaxLength(32)]
    public string? Username { get; set; }

    [Required]
    [PasswordComplexity]
    public string? Password { get; set; }
    public byte[]? PasswordSalt { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
    public DateTime? CreatedAt { get; set; }
}
