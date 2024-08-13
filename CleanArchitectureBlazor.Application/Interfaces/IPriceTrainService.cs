using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Domain.Price_Training;

namespace CleanArchitectureBlazor.Application.Interfaces
{
    public interface IPriceTrainService
    {
        Task Create(TrainDto createTrain);
        Task Delete(Guid id);
        Task<Train> GetById(Guid id);
        Task Update(Guid id, TrainDto updated);
    }
}
