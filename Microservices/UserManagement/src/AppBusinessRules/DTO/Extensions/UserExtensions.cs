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
            PasswordSalt = passwordSaltBytes,
            CreatedAt = DateTime.UtcNow
        };
    }

    public static UserResponseDTO ToUserResponseDTO(this User userData)
    {
        return new UserResponseDTO()
        {
            Username = userData.Username,
            Email = userData.Email,
            CreatedAt = userData.CreatedAt
        };
    }

    public static List<UserListElementResponseDTO> ToUserListElementDTO(this List<User> users)
    {
        List<UserListElementResponseDTO> userList = [];

        userList = users
            .Select(u => new UserListElementResponseDTO()
            {
                Guid = u.Guid,
                Username = u.Username,
                Email = u.Email,
                CreatedAt = u.CreatedAt
            })
            .ToList();

        return userList;
    }
}
