using E_Nak.Application.Model.Response;
using E_Nak.Domain.Entities.Account;

namespace E_Nak.Application.Abstract.Token
{
    public interface ITokenHandler
    {
        TokenResponse CreateAccessToken(int second, User appUser);
        string CreateRefreshToken();
    }
}
