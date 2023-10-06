using E_Nak.Domain.Entities.Account;

namespace E_Nak.Application.Abstract.Service.Auth
{
    public interface ICompanyService
    {
        List<Company> GetAll();
    }
}
