using E_Nak.Domain.Entities.Base;
using System.Linq.Expressions;

namespace E_Nak.Application.Abstract.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> filter);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByIdAsync(int id);
    }
}
