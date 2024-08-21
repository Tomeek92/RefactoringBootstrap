using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Domain.NewsLetterEmails;
using CleanArchitectureBlazor.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureBlazor.Infrastructure.Repository
{
    public class NewsLetterEmailRepository : INewsLetterEmailRepository
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
                bool existingEmail = await _context.NewsLetterEmails.AnyAsync(t => t.Email == email.Email);
                if (existingEmail)
                {
                    throw new Exception($"Podany {email.Email} już istnieje!");
                }
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
                throw new Exception($"Błąd przy pobieraniu z bazy danych rekordu", ex);
            }
        }
        public async Task Delete(Guid id)
        {
            try
            {
                var findEmail = await GetById(id);
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
        public async Task<IEnumerable<NewsLetterEmail>> GetAll()
        {
            try
            {
                var allEmails = await _context.NewsLetterEmails.ToListAsync();
                return allEmails;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Błąd przy pobieraniu listy {ex}");
            }
        }
        
    }
}
