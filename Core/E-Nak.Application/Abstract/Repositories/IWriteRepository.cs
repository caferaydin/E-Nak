using E_Nak.Domain.Entities.Base;

namespace E_Nak.Application.Abstract.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T entity);
        Task<bool> RemoveAsync(int id);
        bool RemoveRange(List<T> datas);
        bool UpdateAsync(T entity);
        Task<int> SaveAsync();

    }
}
