using Entities;
using ServiceInterfaces;

namespace EFCore.Repositories;

public class UserRetrievalRepository : IRetrievalRepository<User>
{
    public async Task<List<User>> GetAllUsers()
    {
        await Task.Delay(1);
        Console.WriteLine("Retrieving entities");
        return await Task.FromResult(MockedEntities.MultipleUsers());
    }

    public async Task<User> GetUserById(Guid guid)
    {
        await Task.Delay(1);
        Console.WriteLine("Retrieving entity");
        return await Task.FromResult(MockedEntities.SingleUser());
    }
}
