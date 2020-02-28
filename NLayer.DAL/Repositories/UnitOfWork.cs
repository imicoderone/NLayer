using Microsoft.EntityFrameworkCore;
using NLayer.DAL.DataContext;
using System.Linq;
using System.Threading.Tasks;

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

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public void Rollback()
        {
            _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }

        public async Task RollbackAsync()
        {
            await Task.Run(() => _context.ChangeTracker.Entries().ToList().ForEach(async x => await x.ReloadAsync()));
        }
    }
}
