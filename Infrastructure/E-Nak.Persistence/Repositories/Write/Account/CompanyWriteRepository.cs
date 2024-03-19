using E_Nak.Application.Repositories.Write.Account;
using E_Nak.Domain.Entities.Account;
using E_Nak.Persistence.Context;

namespace E_Nak.Persistence.Repositories.Write.Account
{
    public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}
