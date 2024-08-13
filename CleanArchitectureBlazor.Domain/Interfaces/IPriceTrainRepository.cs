using CleanArchitectureBlazor.Domain.Price_Training;

namespace CleanArchitectureBlazor.Domain.Interfaces
{
    public interface IPriceTrainRepository
    {
        Task<Train> GetById(Guid id);
        Task Delete(Guid id);
        Task Update(Guid id, Train updated);
        Task Create(Train createTrain);
    }
}
