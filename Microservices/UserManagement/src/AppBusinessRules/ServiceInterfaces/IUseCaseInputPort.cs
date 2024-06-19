using Dtos.Abstractions;
using Entities;

namespace ServiceInterfaces;

public interface IUseCaseInputPort<T>
    where T : DtoBase
{
    public Task<GenericHttpResponse> Handle(T inputData);
}
