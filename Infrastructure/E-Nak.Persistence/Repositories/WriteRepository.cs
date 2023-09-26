using E_Nak.Application.Abstract.Repositories;
using E_Nak.Domain.Entities.Base;
using E_Nak.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace E_Nak.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        
        readonly private MsSqlDbContext _context;

        public WriteRepository(MsSqlDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        #region Method
        public async Task<bool> AddAsync(T entity)
        { 
           EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return Remove(model);
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public bool UpdateAsync(T entity) 
        {
            EntityEntry entityEntry= Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

        #endregion
    }
}
