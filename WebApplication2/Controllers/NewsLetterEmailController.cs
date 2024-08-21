using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Application.Interfaces;
using CleanArchitectureBlazor.Domain.NewsLetterEmails;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureBlazor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsLetterEmailController : ControllerBase
    {
        private readonly INewsLetterEmailService _newsLetterEmailService;
        public NewsLetterEmailController(INewsLetterEmailService newsLetterEmailService)
        {
            _newsLetterEmailService = newsLetterEmailService;
        }
        [HttpPost]
        public async Task Create([FromBody]NewsLetterEmailDto emailDto)
        {
           await _newsLetterEmailService.Create(emailDto);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _newsLetterEmailService.Delete(id);
        }
        [HttpGet("{id}")]
        public async Task<NewsLetterEmailDto> GetById(Guid id)
        {
           var findId = await _newsLetterEmailService.GetById(id);
           return findId;

        }
        [HttpGet]
        public async Task<IEnumerable<NewsLetterEmail>> GetAll()
        {
           var emailsAll = await _newsLetterEmailService.GetAll();
            return emailsAll;
        }
    }
}
