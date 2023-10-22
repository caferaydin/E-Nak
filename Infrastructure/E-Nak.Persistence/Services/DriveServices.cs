using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Application.Abstract.Service.PeopleInformation;
using E_Nak.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Services
{
    public class DriveServices : IDriveService
    {

        #region Field
        readonly private IDriveReadRepository _readRepository;
        readonly private IDriveWriteRepository _writeRepository;
        #endregion

        #region Ctor
        public DriveServices(IDriveReadRepository readRepository, IDriveWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }


        #endregion

        #region Method

        public IQueryable<Drive> GetDrives()
        {
            var drive = _readRepository.GetAll();
            return drive;
        }

        #endregion

    }
}
