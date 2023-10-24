using ETicaretAPI.Application.Exceptions;
using ETicaretAPI.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ETicaretAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;

        public CreateUserCommandHandler(UserManager<Domain.Entities.Identity.AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                UserName = request.Username,
                Email = request.Email,
                NameSurname = request.NameSurname,
                Id = Guid.NewGuid().ToString()

            }, request.Password);
            if (result.Succeeded)
            {
                return new CreateUserCommandResponse() { Success = true, Message = "Oluşturuldu" };
            }
            else
            {
                return new CreateUserCommandResponse() { Success = false, Message = "Oluşturulamadı" };

                //throw new UserCreateFailedException();
            }
        }
    }
}
