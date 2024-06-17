using Dto.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ServiceInterfaces;

public interface IUseCaseInputPort<T, U>
    where U : DtoBase
{
    public Task Handle(U inputData);
}
