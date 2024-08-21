using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Domain.NewsLetterEmails;

namespace CleanArchitectureBlazor.Application.Interfaces
{
    public interface INewsLetterEmailService
    {
        Task Create(NewsLetterEmailDto email);
        Task Delete(Guid Id);
        Task<NewsLetterEmailDto> GetById(Guid id);
        Task<IEnumerable<NewsLetterEmail>> GetAll();
    }
}
