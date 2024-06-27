using Entities;
using ServiceInterfaces;

namespace EFCore.Repositories;

public class UserDeletionRepository : IDeletionRepository<User>
{
    public async Task<User> Delete(Guid entityGuid)
    {
        await Task.Delay(1);
        Console.WriteLine("Deleting entity");
        return await Task.FromResult(MockedEntities.DeletedSingleUser(entityGuid));
    }
}
