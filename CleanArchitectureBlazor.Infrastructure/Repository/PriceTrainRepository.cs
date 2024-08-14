using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Domain.Price_Training;
using CleanArchitectureBlazor.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureBlazor.Infrastructure.Repository
{
    public class PriceTrainRepository : IPriceTrainRepository
    {
        private readonly CleanArchitectureBlazorDbContext _context;
        public PriceTrainRepository(CleanArchitectureBlazorDbContext context)
        {
            _context = context;
        }
        public async Task<Train> GetById(Guid id)
        {
            try
            {
                var findId = await _context.FindAsync<Train>(id);
                if (findId == null)
                {
                    throw new KeyNotFoundException($"Rekord o podanym {id} nie został znaleziony");
                }
                return findId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd przy pobieraniu z bazy danych rekordu", ex);
            }
        }
        public async Task Delete(Guid id)
        {
            try
            {
                var findId = await GetById(id);
                if (findId == null)
                {
                    throw new KeyNotFoundException($"Nie znaleziono rekordu o podanyn {id}");
                }
               _context.Remove(findId);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException($"Nie udało się usunąć rekordu");
            }
        }
        public async Task Create(Train createTrain)
        {
            try
            {
                bool existingTrain = await _context.Trains.AnyAsync(t => t.Name == createTrain.Name);
                if (existingTrain)
                {
                    throw new Exception($"Szkolenie o podanej nazwie {createTrain.Name} już istnieje!");
                }
                _context.Add(createTrain);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd podczas tworzenia szkolenia", ex);
            }
        }
        public async Task Update(Train train)
        {
            try
            {
                var existingTrain = await _context.FindAsync<Train>(train.Id);
                if (existingTrain == null)
                {
                    throw new Exception($"Nie znaleziono szkolenia o podanym numerze{train.Id}");
                }
                _context.Trains.Update(train);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Nieoczekiwany błąd przy aktualizowaniu rekordu",ex);
            }
        }
    }
}
