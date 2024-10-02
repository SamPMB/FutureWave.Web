using FutureWave.Api.Data;
using FutureWave.Api.Entities;
using FutureWave.Api.Repositories.Contracts;
using FutureWave.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace FutureWave.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FutureWaveDbContext futureWaveDbContext;

        public UserRepository(FutureWaveDbContext futureWaveDbContext)
        {
            this.futureWaveDbContext = futureWaveDbContext;
        }
        public async Task<User> GetUser(UserDto users)
        {
            var user = await this.futureWaveDbContext.Users
                .FirstOrDefaultAsync(u => u.Email == users.Email && u.Password == users.Password);
            
            return user;
        }
    }
}
