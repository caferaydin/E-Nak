using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Domain.Entities.Vehicle;
using E_Nak.Persistence.Context;

namespace E_Nak.Persistence.Repositories.Write
{
    public class VehicleWriteRepository : WriteRepository<Vehicles>, IVehicleWriteRepository
    {
        public VehicleWriteRepository(MsSqlDbContext context) : base(context) { }
       
    }
}
