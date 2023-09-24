using E_Nak.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Domain.Entities.Account
{
    public class Individual : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string TaxAdministrator { get; set; }
        public string TaxNo { get; set; }
        public string CommericialTitle { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string BillingAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
