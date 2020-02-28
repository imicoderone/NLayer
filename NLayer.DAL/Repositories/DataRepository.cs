using NLayer.Core.Entities;
using NLayer.DAL.DataContext;
using NLayer.DAL.Repositories.Base;

namespace NLayer.DAL.Repositories
{
    public class DataRepository : Repository<Data>, IDataRepository
    {
        public DataRepository(IDbContext context)
            :base(context)
        {
        }
    }
}
