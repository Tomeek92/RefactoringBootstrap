using CleanArchitectureBlazor.Domain.Price_Training;

namespace CleanArchitectureBlazor.Domain.Interfaces
{
    public interface IPriceTrainRepository
    {
        Task<Train> GetById(Guid id);
        Task Delete(Guid id);
        Task Update(Train train);
        Task Create(Train createTrain);
    }
}
