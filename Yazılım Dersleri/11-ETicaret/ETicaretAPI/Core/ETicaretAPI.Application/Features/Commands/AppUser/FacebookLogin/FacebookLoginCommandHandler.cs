using ETicaretAPI.Application.Abstractions.Token;
using ETicaretAPI.Application.DTOs.Facebook;
using ETicaretAPI.Application.Features.Commands.AppUser.GoogleLogin;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.AppUser.FacebookLogin
{
    public class FacebookLoginCommandHandler : IRequestHandler<FacebookLoginCommandRequest, FacebookLoginCommandResponse>
    {
        private readonly UserManager<ETicaretAPI.Domain.Entities.Identity.AppUser> _userManager;
        private readonly ITokenHandler _tokenHandler;
        private readonly HttpClient _httpClient;

        public FacebookLoginCommandHandler(
            UserManager<Domain.Entities.Identity.AppUser> userManager,
            ITokenHandler tokenHandler,
            IHttpClientFactory httpClientFactory)
        {
            _userManager = userManager;
            _tokenHandler = tokenHandler;
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<FacebookLoginCommandResponse> Handle(FacebookLoginCommandRequest request, CancellationToken cancellationToken)
        {
            string accessTokenResponse = await _httpClient.GetStringAsync($"https://graph.facebook.com/oauth/access_token?client_id=241341215317229&client_secret=fc404176aca2c0e2db1e8ffd705c5ce7&grant_type=client_credentials");

            FacebookAccessTokenResponseDTO facebookAccessTokenResponseDTO = JsonSerializer.Deserialize<FacebookAccessTokenResponseDTO>(accessTokenResponse);

            string userAccessTokenValidation = await _httpClient.GetStringAsync($"https://graph.facebook.com/debug_token?input_token={request.AuthToken}&access_token={facebookAccessTokenResponseDTO.AccessToken}");

            FacebookAccessTokenValidationDTO facebookAccessTokenValidationDTO = JsonSerializer.Deserialize<FacebookAccessTokenValidationDTO>(userAccessTokenValidation);

            if (facebookAccessTokenValidationDTO.Data.IsValid)
            {
                string userInfoResponse = await _httpClient.GetStringAsync($"https://graph.facebook.com/me?fields=email,name&access_token={request.AuthToken}");
                FacebookUserInfoResponse facebookUserInfoResponse = JsonSerializer.Deserialize<FacebookUserInfoResponse>(userInfoResponse);
               
                
                UserLoginInfo userLoginInfo = new("FACEBOOK", facebookAccessTokenValidationDTO.Data.UserId, "FACEBOOK");
                Domain.Entities.Identity.AppUser user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);
                bool result = user != null;
                if (user == null)
                {
                    //user = await _userManager.FindByEmailAsync(payload.Email);
                    if (user == null)
                    {
                        user = new()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Email = facebookUserInfoResponse.Email,
                            UserName = facebookUserInfoResponse.Email,
                            NameSurname = facebookUserInfoResponse.Name
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

                return new FacebookLoginCommandResponse()
                {
                    Token = _tokenHandler.CreateAccessToken(5)
                };
            }

            return new();
        }
    }
}
