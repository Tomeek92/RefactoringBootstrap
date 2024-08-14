using CleanArchitectureBlazor.Application.Dto;

namespace CleanArchitectureBlazor.Application.Interfaces
{
    public interface IPriceService
    {
        Task Create(ServiceDto createService);
        Task Delete(Guid id);
        Task<ServiceDto> GetById(Guid id);
        Task Update(ServiceDto updateService);
    }
}
