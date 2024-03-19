using E_Nak.Domain.Common;

namespace E_Nak.Domain.Entities.Account
{
    public class Individual : BaseBusiness
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
