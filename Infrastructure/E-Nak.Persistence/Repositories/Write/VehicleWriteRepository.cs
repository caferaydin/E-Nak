using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Domain.Entities.Vehicle;
using E_Nak.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Repositories.Write
{
    public class VehicleWriteRepository : WriteRepository<Vehicles>, IVehicleWriteRepository
    {
        public VehicleWriteRepository(MsSqlDbContext context) : base(context) { }
       
    }
}
