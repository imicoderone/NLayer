using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace NLayer.DAL.DataContext
{
    public interface IDbContext
    {
        ChangeTracker ChangeTracker { get; }
        DatabaseFacade Database { get; }
        DbContextId ContextId { get; }
        EntityEntry Add([NotNull] object entity);
        EntityEntry<TEntity> Add<TEntity>([NotNull] TEntity entity) where TEntity : class;
        ValueTask<EntityEntry> AddAsync([NotNull] object entity, CancellationToken cancellationToken = default);
        ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>([NotNull] TEntity entity, CancellationToken cancellationToken = default) where TEntity : class;
        void AddRange([NotNull] params object[] entities);
        void AddRange([NotNull] IEnumerable<object> entities);
        Task AddRangeAsync([NotNull] IEnumerable<object> entities, CancellationToken cancellationToken = default);
        Task AddRangeAsync([NotNull] params object[] entities);
        EntityEntry Attach([NotNull] object entity);
        EntityEntry<TEntity> Attach<TEntity>([NotNull] TEntity entity) where TEntity : class;
        void AttachRange([NotNull] IEnumerable<object> entities);
        void AttachRange([NotNull] params object[] entities);
        EntityEntry Entry([NotNull] object entity);
        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity) where TEntity : class;
        bool Equals(object obj);
        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;
        object Find([NotNull] Type entityType, params object[] keyValues);
        ValueTask<object> FindAsync([NotNull] Type entityType, object[] keyValues, CancellationToken cancellationToken);
        ValueTask<object> FindAsync([NotNull] Type entityType, params object[] keyValues);
        ValueTask<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : class;
        ValueTask<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class;
        int GetHashCode();

        [Obsolete]
        DbQuery<TQuery> Query<TQuery>() where TQuery : class;
        EntityEntry Remove([NotNull] object entity);
        EntityEntry<TEntity> Remove<TEntity>([NotNull] TEntity entity) where TEntity : class;
        void RemoveRange([NotNull] IEnumerable<object> entities);
        void RemoveRange([NotNull] params object[] entities);
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
        EntityEntry Update([NotNull] object entity);
        EntityEntry<TEntity> Update<TEntity>([NotNull] TEntity entity) where TEntity : class;
        void UpdateRange([NotNull] IEnumerable<object> entities);
        void UpdateRange([NotNull] params object[] entities);
    }
}
