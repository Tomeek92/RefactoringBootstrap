using CleanArchitectureBlazor.Domain.NewsLetterEmails;
using CleanArchitectureBlazor.Domain.Price_Training;
using CleanArchitectureBlazor.Infrastructure.Database;

namespace CleanArchitectureBlazor.Infrastructure.Repository
{
    public class PriceRepository
    {
        private readonly CleanArchitectureBlazorDbContext _context;
        public PriceRepository(CleanArchitectureBlazorDbContext context)
        {
            _context = context;
        }
        public async Task<Train> GetById(Guid id)
        {
            try
            {
                var findId = await _context.FindAsync<Train>(id);
                return findId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd przy pobieraniu z bazy danych rekordu", ex);
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
                    findId.Name = updated.Name; //to do: mapowanie na dto 
                    findId.Price = updated.Price;//to do: mapowanie na dto 
                    findId.Category = updated.Category;//to do: mapowanie na dto 
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
