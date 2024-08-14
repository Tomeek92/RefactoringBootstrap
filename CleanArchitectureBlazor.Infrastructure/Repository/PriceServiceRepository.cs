using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureBlazor.Infrastructure.Repository
{
    public class PriceServiceRepository : IPriceServiceRepository
    {
        private readonly CleanArchitectureBlazorDbContext _context;
        public PriceServiceRepository(CleanArchitectureBlazorDbContext context)
        {
            _context = context;
        }
        public async Task<Domain.Service_Price.Service> GetById(Guid id)
        {
            try
            {
                var findId = await _context.FindAsync<Domain.Service_Price.Service>(id);

                if (findId == null)
                {
                    throw new KeyNotFoundException($"Rekord o identyfikatorze {id} nie został znaleziony.");
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
                    throw new KeyNotFoundException($"Rekord o podanym {id} nie został znaleziony");
                }
                _context.Remove(findId);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException($"Nieoczekiwany błąd podczas usuwania");
            }
        }
        public async Task Create(Domain.Service_Price.Service service)
        {
            try
            {
                bool existingService = await _context.Services.AnyAsync(t => t.Name == service.Name);
                if (existingService)
                {
                    throw new Exception($"Rekord o podanej nazwie {service.Name} już istnieje!");
                }
                var addService = _context.Add(service);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                {
                    throw new Exception($"Błąd podczas tworzenia usługi", ex);
                }
            }
        }
        public async Task Update (Domain.Service_Price.Service service)
        {
            try
            {
                var existingService = await _context.FindAsync<Domain.Service_Price.Service>(service.Id);
                if (existingService == null)
                {
                    throw new Exception($"Nie znaleziono usługi o podanym {service.Id}");
                }
                _context.Services.Update(service);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Nieoczekiwany błąd przy aktualizacji rekordu",ex);
            }
        }
    }
}
