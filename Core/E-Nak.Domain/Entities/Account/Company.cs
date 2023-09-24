using E_Nak.Domain.Entities.Base;
using E_Nak.Domain.Entities.Vehicle;

namespace E_Nak.Domain.Entities.Account
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string CompanyAddress { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string TaxAdministrator { get; set; }
        public string TaxNo { get; set; }
        public string BillingAddress { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Vehicles>? Vehicle { get; set; }
    }
}
