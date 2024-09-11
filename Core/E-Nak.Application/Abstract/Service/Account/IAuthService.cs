using E_Nak.Application.Abstract.ExternalService.Authentications;
using E_Nak.Application.Abstract.Service.Account.Authentications;

namespace E_Nak.Application.Abstract.Service.Account
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
        Task PasswordResetAsnyc(string email);
        Task<bool> VerifyResetTokenAsync(string resetToken, string userId);
    }
}
