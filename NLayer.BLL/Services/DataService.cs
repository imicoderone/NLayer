using AutoMapper;
using NLayer.BLL.Abstractions;
using NLayer.Core.DTOs;
using NLayer.DAL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.BLL.Services
{
    public class DataService : EntityService, IDataService
    {
        public DataService(IUnitOfWork uow, IMapper mapper)
            :base(uow, mapper)
        {
        }

        public async Task<IEnumerable<DataDTO>> GetAllAsync()
        {
            return Mapper.Map<IEnumerable<DataDTO>>(await UoW.DataRepository.GetAllAsync());
        }
    }
}
