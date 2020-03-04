using Microsoft.EntityFrameworkCore;
using NLayer.DAL.DataContext;
using NLayer.DAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NLayer.DAL.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IDbContext Context { get; }
        protected DbSet<TEntity> Set { get; }

        public IQueryable<TEntity> AsQueryable { get => Set.AsQueryable(); }

        public Repository(IDbContext context)
        {
            Context = context;
            Set = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll() => Set.ToList();

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await Set.ToListAsync();

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = AsQueryable.FirstOrDefault(predicate);
            if (entity == null)
                throw new NotFoundException($"{typeof(TEntity).Name} not found");

            return entity;
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await AsQueryable.FirstOrDefaultAsync(predicate);
            if (entity == null)
                throw new NotFoundException($"{typeof(TEntity).Name} not found");

            return entity;
        }

        public TEntity GetById(object id)
        {
            var entity = Set.Find(id);
            if (entity == null)
                throw new NotFoundException($"{typeof(TEntity).Name} not found");

            return entity;
        }
        public async Task<TEntity> GetByIdAsync(object id) {
            var entity = await Set.FindAsync(id);
            if (entity == null)
                throw new NotFoundException($"{typeof(TEntity).Name} not found");

            return entity;
        }

        public virtual TEntity Create(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            return entity;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity) => await Task.Run(() => Create(entity));

        public virtual TEntity Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity) => await Task.Run(() => Update(entity));

        public virtual void Delete(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public virtual async Task DeleteAsync(TEntity entity) => await Task.Run(() => Delete(entity));
    }
}
