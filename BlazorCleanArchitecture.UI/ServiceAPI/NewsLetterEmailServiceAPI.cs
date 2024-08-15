using CleanArchitectureBlazor.Application.Dto;

namespace BlazorCleanArchitecture.UI.ServiceAPI
{
    public class NewsLetterEmailServiceAPI
    {
        private readonly HttpClient _httpClient;

        public NewsLetterEmailServiceAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Create(NewsLetterEmailDto emailDto)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7191/api/NewsLetterEmail", emailDto);
            response.EnsureSuccessStatusCode();

        }
        public async Task Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/NewsLetterEmail/{id}");
            response.EnsureSuccessStatusCode();
        }
        public async Task<NewsLetterEmailDto> GetById(Guid id)
        {
            var findId = await _httpClient.GetFromJsonAsync<NewsLetterEmailDto>($"api/NewsLetterEmail/{id}");
            if (findId == null)
            {
                throw new DirectoryNotFoundException($"Nie znaleziono obiektu o takim nr {id} skontaktuj się z administratoremm");
            }
            return findId;
        }


    }
}
