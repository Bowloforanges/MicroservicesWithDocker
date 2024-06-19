using Dtos.Abstractions;
using Entities;

namespace ServiceInterfaces;

public interface IUseCaseOutputPort<T>
    where T : DtoBase
{
    public Task<GenericHttpResponse> Handle(User inputData);
}
