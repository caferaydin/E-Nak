using E_Nak.Domain.Entities.Vehicle;

namespace E_Nak.Application.Abstract
{
    public interface IVehicleService
    {
        List<Vehicles> GetVehicles();
    }
}
