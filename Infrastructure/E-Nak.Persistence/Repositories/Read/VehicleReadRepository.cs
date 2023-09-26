using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Domain.Entities.Vehicle;
using E_Nak.Persistence.Context;

namespace E_Nak.Persistence.Repositories.Read
{
    public class VehicleReadRepository : ReadRepository<Vehicles>, IVehicleReadRepository
    {
        public VehicleReadRepository(MsSqlDbContext context) : base(context) { }
       
    }
}
