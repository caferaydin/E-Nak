using E_Nak.Domain.Entities.Account;
using E_Nak.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Domain.Entities.Vehicle
{
    public class Vehicles : BaseEntity
    {
        public string Brand { get; set; }
        public int Model { get; set; }
        public string PlateNumber { get; set; }
        public string DocumentSerial { get; set; } // 
        public string DocumentNo { get; set; }
        public int ChassisNumber { get; set; }
        public VehicleType? Type { get; set; }
        public Drive? Drive { get; set; }
        public ICollection<Company>? Company { get; set; }
        public ICollection<Individual>? Individual { get; set; }
    }
}
