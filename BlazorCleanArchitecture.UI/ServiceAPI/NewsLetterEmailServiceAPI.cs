using CleanArchitectureBlazor.Application.Dto;

namespace BlazorCleanArchitecture.UI.Service
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
            var response = await _httpClient.PostAsJsonAsync("api/NewsLetterEmail", emailDto);
            response.EnsureSuccessStatusCode();
        }
    }

}
