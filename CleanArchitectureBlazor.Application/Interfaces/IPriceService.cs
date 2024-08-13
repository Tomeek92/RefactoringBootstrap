using CleanArchitectureBlazor.Application.Dto;

namespace CleanArchitectureBlazor.Application.Interfaces
{
    public interface IPriceService
    {
        Task Create(ServiceDto createService);
        Task Delete(Guid id);
        Task<Domain.Service_Price.Service> GetById(Guid id);
    }
}
