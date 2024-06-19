using Entities;
using Utils;

namespace Dtos.Extensions;

public static class UserExtensions
{
    public static User ToUser(this CreateUserRequestDto requestDTO)
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

    public static UserResponseDto ToUserResponseDto(this User userData)
    {
        return new UserResponseDto()
        {
            Username = userData.Username,
            Email = userData.Email,
            CreatedAt = userData.CreatedAt
        };
    }

    public static List<UserListElementResponseDto> ToUserListElementDTO(this List<User> users)
    {
        List<UserListElementResponseDto> userList = [];

        userList = users
            .Select(u => new UserListElementResponseDto()
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
