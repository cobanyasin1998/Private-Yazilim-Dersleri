using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Application.DTOs.User;
using ETicaretAPI.Application.Features.Commands.AppUser.CreateUser;
using ETicaretAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace ETicaretAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;

        public UserService(UserManager<Domain.Entities.Identity.AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser user)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                UserName = user.Username,
                Email = user.Email,
                NameSurname = user.NameSurname,
                Id = Guid.NewGuid().ToString()

            }, user.Password);
            if (result.Succeeded)
            {
                return new CreateUserResponse() { Success = true, Message = "Oluşturuldu" };
            }
            else
            {
                return new CreateUserResponse() { Success = false, Message = "Oluşturulamadı" };

               
            }
        }

       
        public async Task UpdateRefreshToken(string refreshToken, string userId, DateTime accessTokenDate,int refreshTokenLifeTime)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                user.RefreshToken = refreshToken;
                user.RefreshTokenEndDate = accessTokenDate.AddMinutes(refreshTokenLifeTime);
                await _userManager.UpdateAsync(user);
            }
        }
    }
}
