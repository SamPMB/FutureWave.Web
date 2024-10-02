using FutureWave.Api.Entities;
using FutureWave.Api.Repositories.Contracts;
using FutureWave.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutureWave.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository) {
            this.userRepository = userRepository;
        }


        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> GetUser(UserDto users)
        {
          var user = await this.userRepository.GetUser(users);
            return Ok(user);
        }

    }
}
