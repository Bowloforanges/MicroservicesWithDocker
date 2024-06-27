using Dto;
using Entities;
using ServiceInterfaces;

namespace EFCore.Repositories;

public class PasswordChangeRepository : IPasswordRepository<User>
{
    public async Task<User> UpdatePassword(UpdatePasswordRequestDto passwordRequestDto)
    {
        await Task.Delay(1);

        return await Task.FromResult(MockedEntities.SingleUser());
    }
}
