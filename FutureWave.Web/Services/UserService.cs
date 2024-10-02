using FutureWave.Models.Dtos;
using FutureWave.Web.Services.Contracts;
using System.Net.Http.Json;

namespace FutureWave.Web.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<UserDto> GetUser(UserDto userDto)
        {
            var response = await httpClient.PostAsJsonAsync("Api/User/login", userDto);
        

            if (response.IsSuccessStatusCode)
            {

                return await response.Content.ReadFromJsonAsync<UserDto>();

            }
            else
            {

                throw new Exception("Error from the server");

            }






        }

    }
}
