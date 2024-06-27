using Dto;

namespace ServiceInterfaces;

public interface IPasswordRepository<T>
{
    public Task<T> UpdatePassword(UpdatePasswordRequestDto updatePasswordRequest);
}
