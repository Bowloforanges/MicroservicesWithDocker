using Entities;
using ServiceInterfaces;

namespace EFCore.Repositories;

public class UserRetrievalRepository : IRetrievalRepository<User>
{
    private User _mockedUserData = new User()
    {
        Username = "Mocked_username",
        Email = "mocked@email.com",
        CreatedAt = DateTime.Now,
    };

    public async Task<List<User>> GetAllUsers()
    {
        await Task.Delay(1);
        Console.WriteLine("Retrieving entities");
        return await Task.FromResult(new List<User>());
    }

    public async Task<User> GetUserById(Guid guid)
    {
        await Task.Delay(1);
        Console.WriteLine("Retrieving entities");
        return await Task.FromResult(_mockedUserData);
    }
}
