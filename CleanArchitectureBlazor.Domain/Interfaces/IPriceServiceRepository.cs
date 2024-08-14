namespace CleanArchitectureBlazor.Domain.Interfaces
{
    public interface IPriceServiceRepository
    {
        Task<Domain.Service_Price.Service> GetById(Guid id);
        Task Delete(Guid id);
        Task Create(Domain.Service_Price.Service service);
        Task Update(Domain.Service_Price.Service service);
    }
}
