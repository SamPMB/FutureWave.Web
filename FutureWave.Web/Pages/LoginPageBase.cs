using FutureWave.Models.Dtos;
using FutureWave.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace FutureWave.Web.Pages
{
    public class LoginPageBase: ComponentBase
    {


        [Inject]
        public IUserService? UserService { get; set; }

        //[Parameter]
        public UserDto User { get; set; } = new UserDto();

        public UserDto? RetrievedUser { get; set; } = new UserDto();

        public async Task<UserDto> GetUser()
        {

            RetrievedUser = await UserService.GetUser(User);

            return RetrievedUser;
        }









    }
}
