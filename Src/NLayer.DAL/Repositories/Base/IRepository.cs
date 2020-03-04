using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NLayer.DAL.Repositories.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> AsQueryable { get; }

        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();

        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity GetById(object id);
        Task<TEntity> GetByIdAsync(object id);

        TEntity Create(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity);

        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);

        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
