using AutoMapper;
using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Application.Interfaces;
using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Domain.Price_Training;

namespace CleanArchitectureBlazor.Application.Service
{
    public class PriceTrainService : IPriceTrainService
    {
        private readonly IPriceTrainRepository _priceTrainRepository;
        private readonly IMapper _mapper;
        public PriceTrainService(IPriceTrainRepository priceTrainRepository, IMapper mapper)
        {
            _priceTrainRepository = priceTrainRepository;
            _mapper = mapper;
        }
        public async Task Create(TrainDto createTrainDto)
        {
            var createTrain = _mapper.Map<Train>(createTrainDto);
            await _priceTrainRepository.Create(createTrain);
        }

        public async Task Delete(Guid id)
        {
            await _priceTrainRepository.Delete(id);
        }

        public async Task<Train> GetById(Guid id)
        {
           var findId = await _priceTrainRepository.GetById(id);
           return findId;
        }

        public async Task Update(Guid id, TrainDto updatedDto)
        {
            var updated = _mapper.Map<Train>(updatedDto);
            await _priceTrainRepository.Update(id, updated);  
        }
    }
}
