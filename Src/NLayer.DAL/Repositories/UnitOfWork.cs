using NLayer.DAL.Exceptions;
using NLayer.DAL.DataContext;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NLayer.DAL.Repositories.Base;

namespace NLayer.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _context;

        public IDataRepository DataRepository { get; }

        public UnitOfWork(IDbContext context, IDataRepository dataRepository)
        {
            _context = context;
            DataRepository = dataRepository;
        }

        public int Commit()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new CommitException("Can not save changes", e);
            }
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _context.SaveChangesAsync(cancellationToken);
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new CommitException("Can not save changes", e);
            }
        }

        public void Rollback()
        {
            try
            {
                _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new RollbackException("Can not rollback changes", e);
            }
        }

        public async Task RollbackAsync()
        {
            try
            {
                await Task.Run(() => _context.ChangeTracker.Entries().ToList().ForEach(async x => await x.ReloadAsync()));
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new RollbackException("Can not rollback changes", e);
            }
        }
    }
}
