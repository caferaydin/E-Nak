using E_Nak.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace E_Nak.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
