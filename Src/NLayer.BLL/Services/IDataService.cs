using NLayer.BLL.Abstractions;
using NLayer.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.BLL.Services
{
    public interface IDataService : IService
    {
        Task<IEnumerable<DataDTO>> GetAllAsync();

        Task<DataDTO> GetByIdAsync(object id);

        Task<DataDTO> CreateAsync(DataDTO dto);

        Task<DataDTO> UpdateAsync(DataDTO dto);

        Task<int> DeleteAsync(object id);

        Task<int> DeleteAsync(DataDTO dto);
    }
}
