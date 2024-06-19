using Entities;
using ServiceInterfaces;

namespace EFCore.Repositories;

public class CreateUserRepository : ICreationRepository<User>
{
    public async Task<User> Create(User entity)
    {
        await Task.Delay(1);
        Console.WriteLine("creating entity");
        return await Task.FromResult(entity);
    }
}
