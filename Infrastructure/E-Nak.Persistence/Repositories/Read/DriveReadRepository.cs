using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Domain.Entities.Account;
using E_Nak.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Repositories.Read
{
    public class DriveReadRepository : ReadRepository<Drive>, IDriveReadRepository
    {
        public DriveReadRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}
