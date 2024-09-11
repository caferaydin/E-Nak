using E_Nak.Application.Abstract.Service.Account;
using E_Nak.Application.Exceptions.Account;
using E_Nak.Application.Model.Response.User;
using MediatR;

namespace E_Nak.Application.Features.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;
        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateAsync(new()
            {
                Email = request.Email,
                Password = request.Password,
                PasswordConfirm = request.PasswordConfirm,
                Username = request.Username,
            });

            if(response.Succeeded)
            {
                return new()
                {
                    Message = response.Message,
                    Succeeded = response.Succeeded,
                };
            }

            

            throw new UserCreateFailedException();

        }
    }
}
