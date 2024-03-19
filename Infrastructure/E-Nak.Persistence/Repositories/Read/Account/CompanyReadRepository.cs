using E_Nak.Application.Repositories.Read.Account;
using E_Nak.Domain.Entities.Account;
using E_Nak.Persistence.Context;

namespace E_Nak.Persistence.Repositories.Read.Account
{
    public class CompanyReadRepository : ReadRepository<Company>, ICompanyReadRepository
    {
        public CompanyReadRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}
