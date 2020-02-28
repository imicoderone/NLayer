using NLayer.BLL.Abstractions;
using NLayer.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.BLL.Services
{
    public interface IDataService : IService
    {
        Task<IEnumerable<DataDTO>> GetAllAsync();
    }
}
