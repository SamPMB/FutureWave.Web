using FutureWave.Api.Entities;
using FutureWave.Models.Dtos;

namespace FutureWave.Api.Repositories.Contracts
{
    public interface IUserRepository
    {
     public Task<User> GetUser(UserDto user);

    }
}
