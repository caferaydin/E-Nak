using E_Nak.Domain.Entities.Base;

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
