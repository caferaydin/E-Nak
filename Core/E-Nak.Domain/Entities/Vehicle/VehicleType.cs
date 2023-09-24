using E_Nak.Domain.Entities.Base;
using E_Nak.Domain.Entities.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Domain.Entities.Vehicle
{
    public class VehicleType : BaseEntity
    {
        public string TypeName { get; set; }
        public string FloorType { get; set; }
        public string CaseType { get; set; }
        public double MaximumLoad { get; set; }
    }
}
