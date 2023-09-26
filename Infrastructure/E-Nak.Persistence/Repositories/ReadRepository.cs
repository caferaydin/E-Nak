using E_Nak.Application.Abstract.Repositories;
using E_Nak.Domain.Entities.Base;
using E_Nak.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace E_Nak.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly MsSqlDbContext _context;

        public ReadRepository(MsSqlDbContext context)
        {
            _context = context;
        }

        #region Method

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public async Task<T> GetByIdAsync(int id)
            => await Table.FirstOrDefaultAsync(data => data.Id == id);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter)
            => await Table.FirstOrDefaultAsync(filter);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter)
            => Table.Where(filter);

        #endregion
    }
}
