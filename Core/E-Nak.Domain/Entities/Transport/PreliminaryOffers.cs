using E_Nak.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Domain.Entities.Transport
{
    public class PreliminaryOffers : BaseEntity
    {
        public int AccountId { get; set; }
        public double OfferedPrice { get; set; }
    }
}
