
using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Infrastructure.Common;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly SignInManager<User> signInManager;
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AccountService(SignInManager<User> signInManager,
            IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor)
        {
            this.signInManager = signInManager;
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
        }

        public List<GetUserResponse> GetUsers()
        {
            var roles = unitOfWork.Repository<IdentityUserRole<string>>().ListAll()
                .Select(x => new
                {
                    x.UserId,
                    x.RoleId,
                    Role = Constants.UserRoles[x.RoleId]
                });

            return unitOfWork.Repository<User>().ListAll()
                .Where(x => x.IsDeleted == false)
                .Select(x => new GetUserResponse
                {
                    Id = x.Id,
                    Email = x.Email,
                    Avatar = x.Avatar,
                    Role = roles.FirstOrDefault(r => r.UserId == x.Id)?.Role,
                    AccountConfirmed = x.AccountConfirmed
                }).ToList();
        }

        public async Task<BaseResponse> RegisterUser(RegisterUserRequest request)
        {
            User user = new User
            {
                UserName = request.Email,
                Email = request.Email,
                AccountConfirmed = false
            };

            string password = Constants.DEFAULT_PASSWORD;

            var result = await signInManager.UserManager.CreateAsync(user, password);

            return new BaseResponse
            {
                isSuccess = result.Succeeded,
                ErrorMessage = result.Succeeded ? string.Empty : string.Join(", ", result.Errors.Select(e => e.Description))
            };
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

        public async Task<BaseResponse<User>> GetCurrentUser()
        {
            BaseResponse<User> response = new BaseResponse<User>();
            response.isSuccess = false;

            var currentUser = httpContextAccessor.HttpContext
                .User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;

            if (currentUser == null)
            {
                response.ErrorMessage = "Invalid User Account!";
                return response;
            }

            var user = await signInManager.UserManager.FindByEmailAsync(currentUser);
            if (user == null)
            {
                response.ErrorMessage = "Invalid User Account!";
                return response;
            }

            response.isSuccess = true;
            response.Value = user;
            return response;
        }

        public Task<BaseResponse> RemoveUser(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> ChangePassword(ChangePasswordRequest request)
        {
            BaseResponse response = new BaseResponse();
            response.isSuccess = false;

            var user = await GetCurrentUser();
            if (!user.isSuccess)
            {
                response.ErrorMessage = user.ErrorMessage;
                return response;
            }

            var changePasswordResult = await signInManager.UserManager
                .ChangePasswordAsync(user.Value, request.CurrentPassword, request.NewPassword);
            if (changePasswordResult.Succeeded)
            {
                response.isSuccess = true;

                // Confirm account
                await ConfirmAccount(user.Value);
            }
            else
            {
                response.ErrorMessage = changePasswordResult.Errors
                    .FirstOrDefault()?.Description;
            }

            return response;
        }

        private async Task ConfirmAccount(User user)
        {
            if (user.AccountConfirmed == false)
            {
                user.AccountConfirmed = true;

                unitOfWork.Repository<User>()
                    .Update(user);

                await unitOfWork.SaveChanges();
            }
        }

        public Task<BaseResponse> ResetAvatar()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<string>> UploadAvatar(IBrowserFile image)
        {
            throw new NotImplementedException();
        }
    }
}
