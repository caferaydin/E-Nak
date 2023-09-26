using E_Nak.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace E_Nak.Application.Abstract.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
