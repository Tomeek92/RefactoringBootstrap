using CleanArchitectureBlazor.Application.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCleanArchitecture.UI.ServiceAPI
{
    public class ServiceAPI : Controller
    {
       private readonly HttpClient _httpClient;
        public ServiceAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Create(ServiceDto serviceDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/PriceService",serviceDto);
            response.EnsureSuccessStatusCode();
        }
        public async Task Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/PriceService/{id}");
            response.EnsureSuccessStatusCode();
        }
        public async Task<ServiceDto> GetById(Guid id)
        {
            var findId = await _httpClient.GetFromJsonAsync<ServiceDto>($"api/PriceService/{id}");
            if (findId == null)
            {
                throw new DirectoryNotFoundException($"Nie znaleziono obiektu o takim nr {id} skontaktuj się z administratoremm");
            }
            return findId;
        }
        public async Task Update(ServiceDto serviceDto)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/PriceService", serviceDto);
            response.EnsureSuccessStatusCode();
        }
    }
}
