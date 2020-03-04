using AutoMapper;
using NLayer.BLL.DTOs;
using NLayer.DAL.Entities;

namespace NLayer.BLL.Mappings
{
    public class BusinessMappingProfile : Profile
    {
        public BusinessMappingProfile()
        {
            ConfigureMapForDTOToEntity();
            ConfigureMapForEntityToDTO();
        }

        private void ConfigureMapForDTOToEntity()
        {
            CreateMap<DataDTO, Data>();
        }

        private void ConfigureMapForEntityToDTO()
        {
            CreateMap<Data, DataDTO>();
        }
    }
}
