using E_Nak.Domain.Entities.Base;
using E_Nak.Domain.Entities.Vehicle;

namespace E_Nak.Domain.Entities.Account
{
    public class Drive : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Vehicles> Vehicles { get; set; }


    }
}
