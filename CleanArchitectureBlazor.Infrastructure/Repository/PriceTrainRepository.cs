using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Domain.Price_Training;
using CleanArchitectureBlazor.Infrastructure.Database;

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
                _context.Add(createTrain);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Nieoczekiwany błąd przy tworzeniu szkolenia", ex);
            }
        }

        public async Task Update(Guid id,Train updated)
        {
            try
            {
                var findId = await GetById(id);

                if (findId == null)
                {
                    throw new KeyNotFoundException($"Nie znaleziono rekordu o podanym Id {id}");
                }
                else
                {
                    findId.Name = updated.Name; 
                    findId.Price = updated.Price;
                    findId.Category = updated.Category;
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Nieoczekiwany błąd");
            }
        }
    }
}
