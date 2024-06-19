namespace ServiceInterfaces;

public interface IRetrievalRepository<T>
{
    public Task<T> GetUserById(Guid guid);
    public Task<List<T>> GetAllUsers();
}
