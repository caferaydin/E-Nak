using E_Nak.Application.Model.Response;

namespace E_Nak.Application.Abstract.Service.Account.Authentications
{
    public interface IInternalAuthentication
    {
        Task<TokenResponse> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
        Task<TokenResponse> RefreshTokenLoginAsync(string refreshToken);
    }
}
