using AutoMapper;
using CleanArchitectureBlazor.Application.Dto;
using CleanArchitectureBlazor.Application.Interfaces;
using CleanArchitectureBlazor.Domain.Interfaces;
using CleanArchitectureBlazor.Domain.NewsLetterEmails;

namespace CleanArchitectureBlazor.Application.Service
{
    public class NewsLetterEmailService : INewsLetterEmailService
    {
        private readonly INewsLetterEmailRepository _newsLetterEmailRepository;
        private readonly IMapper _mapper;
        public NewsLetterEmailService(INewsLetterEmailRepository newsLetterEmail, IMapper mapper)
        {
            _newsLetterEmailRepository = newsLetterEmail;
            _mapper = mapper;
        }
       public async Task Create(NewsLetterEmailDto emailDto)
        {
            var email = _mapper.Map<NewsLetterEmail>(emailDto);

           await  _newsLetterEmailRepository.Create(email);
        }
        public async Task Delete(Guid Id)
        {
           await _newsLetterEmailRepository.Delete(Id);
        }
        public async Task<NewsLetterEmailDto> GetById(Guid id)
        {
            var findId = await _newsLetterEmailRepository.GetById(id);
            var mapp = _mapper.Map<NewsLetterEmailDto>(id);
            return mapp; 
        }
    }
}
