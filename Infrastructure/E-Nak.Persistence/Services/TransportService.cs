using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Application.Abstract.Service;
using E_Nak.Domain.Entities.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Services
{
    public class TransportService : ITransportService
    {

        #region Field
        readonly ITransportReadRepository _readRepository;
        readonly ITransportWriteRepository _writeRepository;

        #endregion

        #region Ctor

        public TransportService(ITransportReadRepository readRepository, ITransportWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }
        #endregion

        #region Method

        public IQueryable<Transport> GetTransports()
        {
            return _readRepository.GetAll();
        }

        #endregion
    }
}
