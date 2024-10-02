using FutureWave.Models.Dtos;

namespace FutureWave.Web.Services.Contracts
{
    public interface IUserService
    {
        public Task<UserDto> GetUser(UserDto userDto);
    }
}
