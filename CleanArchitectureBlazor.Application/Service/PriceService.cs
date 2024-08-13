using AutoMapper;
using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Application.Interfaces;
using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Domain.Service_Price;

namespace CleanArchitectureBlazor.Application.Service
{
    public class PriceService : IPriceService
    {
        private readonly IPriceServiceRepository _PriceServiceRepository;
        private readonly IMapper _mapper;
        public PriceService(IPriceServiceRepository priceServiceRepository, IMapper mapper)
        {
            _PriceServiceRepository = priceServiceRepository;
            _mapper = mapper;
        }
        public async Task Create(ServiceDto createServiceDto)
        {
            var createService = _mapper.Map<Domain.Service_Price.Service>(createServiceDto);
            await _PriceServiceRepository.Create(createService);
        }

        public async Task Delete(Guid id)
        {
          await  _PriceServiceRepository.Delete(id);
        }

        public async Task<Domain.Service_Price.Service> GetById(Guid id)
        {
          var findId = await GetById(id);
          return findId;
        }
    }
}
