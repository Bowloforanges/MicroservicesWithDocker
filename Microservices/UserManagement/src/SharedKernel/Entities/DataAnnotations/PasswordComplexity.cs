using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Entities.DataAnnotations;

public class PasswordComplexity : ValidationAttribute
{
    public PasswordComplexity()
    {
        ErrorMessage =
            "Password must be at least 8 characters long, contain at least 1 uppercase letter, 1 lowercase letter, 1 number, and 1 special character.";
    }

    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult(ErrorMessage);
        }

        string password = value.ToString() ?? "";

        if (
            password.Length < 8
            && password.Length <= 32
            && !Regex.IsMatch(password, @"[A-Z]")
            && // At least one uppercase letter
            !Regex.IsMatch(password, @"[a-z]")
            && // At least one lowercase letter
            !Regex.IsMatch(password, @"[0-9]")
            && // At least one number
            (
                !Regex.IsMatch(password, @"[~`!@#$%^&*()\-_=+{}\[\]|\\;:'<>,./?]")
                || !Regex.IsMatch(password, "\"")
            )
        ) // At least one special character
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success!;
    }
}
