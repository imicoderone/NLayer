using AutoMapper;
using NLayer.DAL.Repositories.Base;

namespace NLayer.BLL.Services.Base
{
    public class EntityService : IEntityService
    {
        protected IUnitOfWork UoW { get; }
        protected IMapper Mapper { get; }

        public EntityService(IUnitOfWork uow, IMapper mapper)
        {
            UoW= uow;
            Mapper = mapper;
        }
    }
}
