using Dto.Abstractions;
using Entities;

namespace ServiceInterfaces;

public interface IUseCaseOutputPort<U>
    where U : DtoBase
{
    public Task<GenericHttpResponse> Handle(U inputData);
}
