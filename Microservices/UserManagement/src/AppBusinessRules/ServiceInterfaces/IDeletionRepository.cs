namespace ServiceInterfaces;

public interface IDeletionRepository<T>
{
    Task<T> Delete(Guid entityGuid);
}
