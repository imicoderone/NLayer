using AutoMapper;
using NLayer.Api.Models;
using NLayer.BLL.DTOs;

namespace NLayer.Api.Mappings
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            ConfigureMapForModelToDTO();
            ConfigureMapForDTOToModel();
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
    }
}
