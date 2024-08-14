using AutoMapper;
using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Application.Interfaces;
using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Domain.Service_Price;

namespace CleanArchitectureBlazor.Application.Service
{
    public class PriceService : IPriceService
    {
        private readonly IPriceServiceRepository _priceServiceRepository;
        private readonly IMapper _mapper;
        public PriceService(IPriceServiceRepository priceServiceRepository, IMapper mapper)
        {
            _priceServiceRepository = priceServiceRepository;
            _mapper = mapper;
        }
        public async Task Create(ServiceDto createServiceDto)
        {
            var createService = _mapper.Map<Domain.Service_Price.Service>(createServiceDto);
            await _priceServiceRepository.Create(createService);
        }

        public async Task Delete(Guid id)
        {
          await  _priceServiceRepository.Delete(id);
        }

        public async Task<ServiceDto> GetById(Guid id)
        {
          var findId = await _priceServiceRepository.GetById(id);
          var mapp = _mapper.Map<ServiceDto>(id);
          return mapp;
        }
        public async Task Update (ServiceDto updateServiceDto)
        {
            var updateService = _mapper.Map<Domain.Service_Price.Service>(updateServiceDto);
            await _priceServiceRepository.Update(updateService);
        }
    }
}
