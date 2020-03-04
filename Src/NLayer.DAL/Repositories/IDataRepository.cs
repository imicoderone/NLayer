using NLayer.DAL.Entities;
using NLayer.DAL.Repositories.Base;
using System.Threading.Tasks;

namespace NLayer.DAL.Repositories
{
    public interface IDataRepository : IRepository<Data>
    {
        Data GetByName(string name);
        Task<Data> GetByNameAsync(string name);
    }
}
