using Microsoft.EntityFrameworkCore;
using NLayer.DAL.DataContext;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<TEntity> GetAll() => Set.ToList();

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await Set.ToListAsync();

        public TEntity GetById(object id) => Set.Find(id);
        public async Task<TEntity> GetByIdAsync(object id) => await Set.FindAsync(id);

        public TEntity Create(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity) => await Task.Run(() => Create(entity));

        public TEntity Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity) => await Task.Run(() => Update(entity));

        public void Delete(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public async Task DeleteAsync(TEntity entity) => await Task.Run(() => Delete(entity));
    }
}
