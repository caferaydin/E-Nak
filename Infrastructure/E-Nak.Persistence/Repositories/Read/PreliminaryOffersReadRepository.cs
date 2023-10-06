using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Domain.Entities.Transport;
using E_Nak.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Persistence.Repositories.Read
{
    public class PreliminaryOffersReadRepository : ReadRepository<PreliminaryOffers>, IPreliminaryOffersReadRepository
    {
        public PreliminaryOffersReadRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}
