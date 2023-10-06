using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Domain.Entities.Account;
using E_Nak.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Repositories.Write
{
    public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}
