namespace E_Nak.Domain.Common
{
    public class BaseTransport : BaseEntity
    {
        public string LoadType { get; set; } // Yük Tipleri Enumeration
        public string InstallationType { get; set; } // yükleme tipi Enumeration
        public string LoadCity { get; set; } // Yük İli 
        public string LoadDistrict { get; set; }
        public string LoadCityX { get; set; } // googleMaps
        public string LoadCityY { get; set; } // googleMaps
        public string UnLoadCity { get; set; }
        public string UnLoadDistrict { get; set; }
        public string UnLoadCityX { get; set; } // googleMaps
        public string UnLoadCityY { get; set; } // googleMaps
        public DateTime LoadDate { get; set; } // Yük Yarihi
        public DateTime UnLoadDate { get; set; } //Boşaltma Tarihi
        public bool IsActive { get; set; }

    }
}
