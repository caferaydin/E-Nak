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
    public class DriveWriteRepository : WriteRepository<Drive>, IDriveWriteRepository
    {
        public DriveWriteRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}
