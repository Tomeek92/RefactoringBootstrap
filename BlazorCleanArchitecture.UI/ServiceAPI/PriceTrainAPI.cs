using CleanArchitectureBlazor.Application.Dto;

namespace BlazorCleanArchitecture.UI.ServiceAPI
{
    public class PriceTrainAPI
    {
        private readonly HttpClient _httpClient;
        public PriceTrainAPI(HttpClient httpClient)
        {
            _httpClient = httpClient; 
        }
        public async Task Create (TrainDto trainDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/PriceTrain", trainDto);
            response.EnsureSuccessStatusCode();
        }
        public async Task Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/PriceTrain/{id}");
            response.EnsureSuccessStatusCode(); 
        }
        public async Task<TrainDto> GetById(Guid id)
        {
            var findId = await _httpClient.GetFromJsonAsync<TrainDto>($"api/PriceTrain/{id}");
            if(findId == null)
            {
                throw new Exception($"Nie znaleziono obiektu o takim nr {id} skontaktuj się z administratoremm");
            }
            return findId;
        }
        public async Task Update(TrainDto trainDto)
        {
           var response = await _httpClient.PutAsJsonAsync($"api/PriceTrain",trainDto);
            response.EnsureSuccessStatusCode();
            
        }
    }
}
