using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Application.Interfaces;
using CleanArchitectureBlazor.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureBlazor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceTrainController : ControllerBase
    {
        private readonly IPriceTrainService _priceTrainService;
        public PriceTrainController(IPriceTrainService priceTrainService)
        {
            _priceTrainService = priceTrainService; 
        }
        [HttpPost]
        public async Task Create([FromBody]TrainDto trainDto)
        {
            await _priceTrainService.Create(trainDto);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _priceTrainService.Delete(id);
        }
        [HttpGet("{id}")]
        public async Task<TrainDto> GetById(Guid id)
        {
            var findId = await _priceTrainService.GetById(id);
            return findId;
        }
        [HttpPut]
        public async Task Update([FromBody]TrainDto trainDto)
        {
            await _priceTrainService.Update(trainDto);
        }
    }
}
