using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Application.Abstract.Service;
using E_Nak.Domain.Entities.Vehicle;

namespace E_Nak.Persistence.Concretes
{
    public class VehicleService : IVehicleService
    {

        #region Field
        readonly IVehicleReadRepository _readRepository;
        readonly IVehicleWriteRepository _writeRepository;
        #endregion

        #region Ctor

        public VehicleService( IVehicleReadRepository readRepository, IVehicleWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }
        #endregion



        #region Method
        public IQueryable<Vehicles> GetVehicles()
        {
            return _readRepository.GetAll();
        }
        #endregion
    }
}
