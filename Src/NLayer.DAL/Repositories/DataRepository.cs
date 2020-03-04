using NLayer.DAL.Entities;
using NLayer.DAL.DataContext;
using NLayer.DAL.Repositories.Base;
using System.Threading.Tasks;
using NLayer.DAL.Exceptions;

namespace NLayer.DAL.Repositories
{
    public class DataRepository : Repository<Data>, IDataRepository
    {
        public DataRepository(IDbContext context)
            : base(context)
        {
        }

        public Data GetByName(string name)
        {
            try
            {
                return Find(p => p.Name == name);
            }
            catch (NotFoundException e)
            {
                throw new NotFoundException($"Data with Name: {name} not found", e);
            }
        }

        public async Task<Data> GetByNameAsync(string name)
        {
            try
            {
                return await FindAsync(p => p.Name == name);
            }
            catch (NotFoundException e)
            {
                throw new NotFoundException($"Data with Name: {name} not found", e);
            }
        }
    }
}
