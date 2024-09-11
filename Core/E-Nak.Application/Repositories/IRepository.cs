using E_Nak.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace E_Nak.Application.Repositories
{
    public interface IRepository<T, Val> where T : BaseEntity<Val>
    {
        DbSet<T> Table { get; }
    }
}
