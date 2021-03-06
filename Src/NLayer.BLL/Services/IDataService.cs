﻿using NLayer.BLL.Services.Base;
using NLayer.BLL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.BLL.Services
{
    public interface IDataService : IService
    {
        Task<IEnumerable<DataDTO>> GetAllAsync();

        Task<IEnumerable<DataDTO>> GetArchivedAsync();

        Task<DataDTO> GetByIdAsync(object id);

        Task<DataDTO> GetByNameAsync(string name);

        Task<DataDTO> CreateAsync(DataDTO dto);

        Task<DataDTO> UpdateAsync(DataDTO dto);

        Task<int> DeleteAsync(object id);

        Task<int> DeleteAsync(DataDTO dto);
    }
}
