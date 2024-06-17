using Entities.Abstractions;

namespace ServiceInterfaces;

public interface IUnitOfWork<T>
    where T : EntityBase
{
    public Task CommitTransaction();
}
