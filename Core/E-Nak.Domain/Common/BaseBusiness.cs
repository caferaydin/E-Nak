using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Domain.Common
{
    public class BaseBusiness : BaseEntity
    {
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? BillingAddress { get; set; }
        public string? TaxNumber { get; set; }
        public string? TaxAdministrator { get; set; }
        public bool IsActive { get; set; }
    }
}
