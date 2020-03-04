using AutoMapper;
using NLayer.Api.Models;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;

namespace NLayer.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ConfigureMapForModelToDTO();
            ConfigureMapForDTOToModel();
            ConfigureMapForDTOToEntity();
            ConfigureMapForEntityToDTO();
        }

        private void ConfigureMapForModelToDTO()
        {
            CreateMap<CreateDataModel, DataDTO>();
            CreateMap<UpdateDataModel, DataDTO>();
        }

        private void ConfigureMapForDTOToModel()
        {
            CreateMap<DataDTO, DataViewModel>();
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
