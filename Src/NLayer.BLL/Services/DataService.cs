using AutoMapper;
using NLayer.BLL.Services.Base;
using NLayer.BLL.DTOs;
using NLayer.DAL.Entities;
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

        public async Task<DataDTO> GetByIdAsync(object id)
        {
            return Mapper.Map<DataDTO>(await UoW.DataRepository.GetByIdAsync(id));
        }

        public async Task<DataDTO> CreateAsync(DataDTO dto)
        {
            var entity = Mapper.Map<Data>(dto);
            entity = await UoW.DataRepository.CreateAsync(entity);
            await UoW.CommitAsync();
            return Mapper.Map<DataDTO>(entity);
        }

        public async Task<DataDTO> UpdateAsync(DataDTO dto)
        {
            var entity = await UoW.DataRepository.GetByIdAsync(dto.Id);
            entity = Mapper.Map(dto, entity);
            entity = await UoW.DataRepository.UpdateAsync(entity);
            await UoW.CommitAsync();
            return Mapper.Map<DataDTO>(entity);
        }

        public async Task<int> DeleteAsync(object id)
        {
            var entity = await UoW.DataRepository.GetByIdAsync(id);
            await UoW.DataRepository.DeleteAsync(entity);
            return await UoW.CommitAsync();
        }

        public async Task<int> DeleteAsync(DataDTO dto)
        {
            return await DeleteAsync(dto.Id);
        }
    }
}
