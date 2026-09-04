
using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly SignInManager<User> signInManager;

        public AccountService(SignInManager<User> signInManager)
        {
            this.signInManager = signInManager;
        }


        public Task<BaseResponse> RegisterUser(RegisterUserRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<string>> VerifyUser(string email, string password)
        {
            BaseResponse<string> response = new();

            var user = await signInManager.UserManager.FindByEmailAsync(email);
            if (user is null)
            {
                response.ErrorMessage = "User not found";
                response.isSuccess = false;
                return response;
            }

            var result = await signInManager.UserManager.
                CheckPasswordAsync(user, password);

            response.isSuccess = result;
            if (!result)
            {
                response.ErrorMessage = "Invalid email or password";
            }
            else
            {
                response.Value = user.UserName;
            }
            
            return response;
        }
    }
}
