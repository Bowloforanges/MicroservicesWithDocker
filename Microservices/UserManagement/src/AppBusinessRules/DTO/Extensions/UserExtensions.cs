using Entities;
using Utils;

namespace DTO.Extensions;

public static class UserExtensions
{
    public static User ToUser(this CreateUserRequestDTO requestDTO)
    {
        PasswordUtils passwordUtils = new PasswordUtils();

        return new User()
        {
            Guid = Guid.NewGuid(),
            Username = requestDTO.Username,
            Email = requestDTO.Email,
            Password = passwordUtils.HashAndSalt(
                requestDTO.Password!,
                out byte[] passwordSaltBytes
            ),
            PasswordSalt = passwordSaltBytes
        };
    }
}
