using E_Nak.Domain.Entities.Transport;

namespace E_Nak.Application.Abstract.Service
{
    public interface ITransportService
    {
        IQueryable<Transport> GetTransports();
    }
}
