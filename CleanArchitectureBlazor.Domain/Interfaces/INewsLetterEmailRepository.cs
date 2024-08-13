using CleanArchitectureBlazor.Domain.NewsLetterEmails;

namespace CleanArchitectureBlazor.Domain.Interfaces
{
    public interface INewsLetterEmailRepository
    {
        Task Create(NewsLetterEmail email);
        Task<NewsLetterEmail> GetById(Guid id);
        Task Delete(Guid id);
    }
}
