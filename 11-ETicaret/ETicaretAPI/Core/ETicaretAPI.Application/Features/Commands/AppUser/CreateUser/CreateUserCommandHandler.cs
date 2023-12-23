using ETicaretAPI.Application.Abstractions.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ETicaretAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _userService.CreateAsync(new DTOs.User.CreateUser()
            {
                Email = request.Email,
                NameSurname = request.NameSurname,
                Password = request.Password,
                Repassword = request.Repassword,
                Username = request.Username
            });

            return new CreateUserCommandResponse() { Message = data.Message, Success = data.Success };
        }
    }
}
