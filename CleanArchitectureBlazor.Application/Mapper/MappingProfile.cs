using AutoMapper;
using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Domain.Admin;
using CleanArchitectureBlazor.Domain.Price_Training;

namespace CleanArchitectureBlazor.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountDto,Account>();
            CreateMap<TrainDto,Train>();
            CreateMap<ServiceDto,Domain.Service_Price.Service>();
        }

    }
}
