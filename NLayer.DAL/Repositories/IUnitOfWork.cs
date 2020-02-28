using System.Threading.Tasks;

namespace NLayer.DAL.Repositories
{
    public interface IUnitOfWork
    {
        IDataRepository DataRepository { get; }

        void Commit();
        Task CommitAsync();

        void Rollback();
        Task RollbackAsync();
    }
}
