using ETicaretAPI.Application.Exceptions;
using ETicaretAPI.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ETicaretAPI.Application.Features.Commands.AppUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;
        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                UserName = request.Username,
                Email = request.Email,
                NameSurname = request.NameSurname

            }, request.Password);
            if (result.Succeeded)
            {
                return new CreateUserCommandResponse() { Success = true,Message = "Oluşturuldu" };
            }
            else
            {
                throw new UserCreateFailedException();
            }
        }
    }
}
