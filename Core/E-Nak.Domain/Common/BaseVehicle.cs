using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Domain.Common
{
    public class BaseVehicle : BaseEntity
    {
        public string PlateNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public string DocumentSerial { get; set; }
    }
}
