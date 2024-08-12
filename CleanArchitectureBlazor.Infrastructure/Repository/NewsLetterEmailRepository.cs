using CleanArchitectureBlazor.Domain.NewsLetterEmails;
using CleanArchitectureBlazor.Infrastructure.Database;

namespace CleanArchitectureBlazor.Infrastructure.Repository
{
    public class NewsLetterEmailRepository
    {
        private readonly CleanArchitectureBlazorDbContext _context;
        public NewsLetterEmailRepository(CleanArchitectureBlazorDbContext context)
        {
            _context = context;
        }
        public async Task Create(NewsLetterEmail email)
        {
            try
            {
                _context.Add(email);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd podczas dodawania e-mail do newslettera", ex);
            }
        }
        public async Task<NewsLetterEmail> GetById(Guid id)
        {
            try
            {
                var findId = await _context.FindAsync<NewsLetterEmail>(id);
                return findId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd przy pobieraniu z bazy danych rekordu",ex);
            }
        }
        public async Task Delete(Guid id)
        {
            try
            {
                var findEmail = GetById(id);
                if (findEmail == null)
                {
                    throw new KeyNotFoundException($"Rekord o danym {id} nie został znaleziony ");
                }
                    _context.Remove(findEmail);
                    await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Błąd przy usuwaniu rekordu o podanym ID {id}", ex);
            }           
        }

    }
}
