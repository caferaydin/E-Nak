﻿using E_Nak.Domain.Entities.Transport;
using E_Nak.Domain.Entities.Vehicle;

namespace E_Nak.Application.ViewModel.Request
{
    public class TransportUpdateRequest
    {
        public int id { get; set; }
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
