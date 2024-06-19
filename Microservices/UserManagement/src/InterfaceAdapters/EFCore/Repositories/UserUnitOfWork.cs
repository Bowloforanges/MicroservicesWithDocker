using Entities;
using ServiceInterfaces;

namespace EFCore.Repositories;

public class UserUnitOfWork : IUnitOfWork<User>
{
    public Task CommitTransaction()
    {
        return Task.CompletedTask;
    }
}
