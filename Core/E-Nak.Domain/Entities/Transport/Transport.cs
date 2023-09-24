using E_Nak.Domain.Entities.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Domain.Entities.Transport
{
    public class Transport
    {
        public VehicleType VehicleType { get; set; }
        public LoadType LoadType { get; set; }
        public string LoadProvince { get; set; }
        public string LoadDistrict { get; set; }
        public string UnloadProvience { get; set; }
        public string UnloadDistrict { get; set; }
        public int PolicyNumber { get; set; }
        public DateTime LoadDate { get; set; }
        public DateTime LoadDeliveryDate { get; set; }
    }
}
