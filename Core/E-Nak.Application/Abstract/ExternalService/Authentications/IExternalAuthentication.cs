using E_Nak.Application.Model.Response;

namespace E_Nak.Application.Abstract.ExternalService.Authentications
{
    public interface IExternalAuthentication
    {
        Task<TokenResponse> FacebookLoginAsync(string authToken, int accessTokenLifeTime);
        Task<TokenResponse> GoogleLoginAsync(string idToken, int accessTokenLifeTime);
    }
}
