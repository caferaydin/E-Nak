using E_Nak.Domain.Common;
using E_Nak.Domain.Entities.Account;

namespace E_Nak.Domain.Entities.Datas.Transport
{
    public class Transport : BaseTransport
    {
        public int? ProducerId { get; set; }
        public Company Producer { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
