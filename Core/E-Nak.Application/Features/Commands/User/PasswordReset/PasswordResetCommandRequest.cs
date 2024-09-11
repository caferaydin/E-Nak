using MediatR;

namespace E_Nak.Application.Features.Commands.User.PasswordReset
{
    public class PasswordResetCommandRequest : IRequest<PasswordResetCommandResponse>
    {
        public string Email { get; set; }
    }
}
