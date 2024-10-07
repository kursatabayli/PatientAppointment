using Newtonsoft.Json;
using PatientAppointment.WebUI.Services.Interfaces;
using System.Text;

namespace PatientAppointment.WebUI.Services.Implementations
{
    public class ApiService<T> : IApiService<T>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly string _baseUrl;

        public ApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _baseUrl = _configuration["ApiUrls:BaseApiUrl"]!;
        }


        public async Task<List<T>> GetListAsync(string url)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync(_baseUrl + url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<T>>(jsonData);
            }

            return new List<T>();
        }

        public async Task<T> GetItemAsync(string url)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync(_baseUrl + url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonData);
            }

            return default;
        }

        public async Task<bool> CreateItemAsync(string url, T item)
        {
            var client = _httpClientFactory.CreateClient();

            var jsonData = JsonConvert.SerializeObject(item);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(_baseUrl + url, stringContent);

            return responseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteItemAsync(string url)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.DeleteAsync(_baseUrl + url);
            return responseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemAsync(string url, T item)
        {
            var client = _httpClientFactory.CreateClient();

            var jsonData = JsonConvert.SerializeObject(item);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync(_baseUrl + url, stringContent);

            return responseMessage.IsSuccessStatusCode;
        }

        public async Task GetEmpty()
        {
            var client = _httpClientFactory.CreateClient();
        }
    }
}
