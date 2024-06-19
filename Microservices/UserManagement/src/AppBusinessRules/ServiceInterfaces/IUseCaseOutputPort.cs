using Entities;

namespace ServiceInterfaces;

public interface IUseCaseOutputPort<T>
{
    public Task<GenericHttpResponse> Handle(T inputData);
}
