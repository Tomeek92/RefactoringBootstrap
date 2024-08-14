using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureBlazor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceServiceController : ControllerBase
    {
        private readonly IPriceService _priceService;
        public PriceServiceController(IPriceService priceService)
        {
            _priceService = priceService;
        }
        [HttpPost]
        public async Task Create([FromBody]ServiceDto serviceDto)
        {
            await _priceService.Create(serviceDto);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _priceService.Delete(id);
        }
        [HttpGet("{id}")]
        public async Task<ServiceDto> GetById(Guid id)
        {
           var findId = await _priceService.GetById(id);
           return findId;
        }
        [HttpPut]
        public async Task Update([FromBody]ServiceDto serviceDto)
        {
            await _priceService.Update(serviceDto);
        }

    }
}
