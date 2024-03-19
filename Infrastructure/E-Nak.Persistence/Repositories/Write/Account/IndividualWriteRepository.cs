using E_Nak.Application.Repositories.Write.Account;
using E_Nak.Domain.Entities.Account;
using E_Nak.Persistence.Context;

namespace E_Nak.Persistence.Repositories.Write.Account
{
    public class IndividualWriteRepository : WriteRepository<Individual>, IIndividualWriteRepository
    {
        public IndividualWriteRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}
