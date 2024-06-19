namespace ServiceInterfaces;

public interface ICreationRepository<T>
{
    Task<T> Create(T entity);
}
