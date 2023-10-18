using E_Nak.Domain.Entities.Identity;

namespace E_Nak.Application.Abstract.Token
{
    public interface ITokenHandler
    {
        DTOs.Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
