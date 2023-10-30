using ETicaretAPI.Application.Abstractions.Token;
using Google.Apis.Auth;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ETicaretAPI.Application.Features.Commands.AppUser.GoogleLogin
{

    public class GoogleLoginCommandHandler : IRequestHandler<GoogleLoginCommandRequest, GoogleLoginCommandResponse>
    {
        private readonly UserManager<ETicaretAPI.Domain.Entities.Identity.AppUser> _userManager;
        private readonly ITokenHandler _tokenHandler;

        public GoogleLoginCommandHandler(UserManager<Domain.Entities.Identity.AppUser> userManager, ITokenHandler tokenHandler)
        {
            _userManager = userManager;
            _tokenHandler = tokenHandler;
        }

        public async Task<GoogleLoginCommandResponse> Handle(GoogleLoginCommandRequest request, CancellationToken cancellationToken)
        {

            var settings = new GoogleJsonWebSignature.ValidationSettings()
            {
                Audience = new List<string> { "1043195462092-f4sao709glhokupek62qeq2aaruvhkft.apps.googleusercontent.com" }
            };

            var payload = await GoogleJsonWebSignature.ValidateAsync(request.IdToken, settings);
            UserLoginInfo userLoginInfo = new(request.Provider, payload.Subject, request.Provider);
            Domain.Entities.Identity.AppUser user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);
            bool result = user != null;
            if (user == null)
            {
                //user = await _userManager.FindByEmailAsync(payload.Email);
                if (user == null)
                {
                    user = new() { 
                        Id = Guid.NewGuid().ToString(), 
                        Email = payload.Email, 
                        UserName = payload.Email,
                        NameSurname = payload.Name
                        //Provider = request.Provider 
                    };
                    IdentityResult createResult = await _userManager.CreateAsync(user);
                    result = createResult.Succeeded;
                }
            }

            if (result)
                await _userManager.AddLoginAsync(user, userLoginInfo);
            else
                throw new Exception("Invalid external authentication.");

            return new GoogleLoginCommandResponse() {
                Token = _tokenHandler.CreateAccessToken(5)
            };
            

        }
    }


}
