namespace ServiceInterfaces;

public interface IUpdateRepository<T>
{
    public Task<T> Update(T entity);
}
