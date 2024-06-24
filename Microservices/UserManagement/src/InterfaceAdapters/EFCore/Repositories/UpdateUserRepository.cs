using Entities;
using ServiceInterfaces;

namespace EFCore.Repositories;

public class UpdateUserRepository : IUpdateRepository<User>
{
    public async Task<User> Update(User userToUpdate)
    {
        await Task.Delay(1);
        Console.WriteLine("Updating entity");
        return await Task.FromResult(MockedEntities.UpdatedSingleUser(userToUpdate.Guid));
    }
}
