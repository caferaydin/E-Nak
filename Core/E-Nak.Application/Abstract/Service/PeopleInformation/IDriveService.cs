using E_Nak.Domain.Entities.Account;

namespace E_Nak.Application.Abstract.Service.PeopleInformation
{
    public interface IDriveService
    {
        IQueryable<Drive> GetDrives();
    }
}
