
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Models
{
    public class DynamicConsume<T> where T : class
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DynamicConsume(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<T>> GetListAsync(string link)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44374/api/{link}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<T>>(jsonData);
                return values;
            }
            return new List<T>();
        }
        public async Task<T> GetByIdAsync(string link,int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44374/api/{link}/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<T>(jsonData);
                return values;
            }
            return null;
        }
        public async Task<List<T>> GetListByIdAsync(string link, int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44374/api/{link}/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<T>>(jsonData);
                return values;
            }
            return new List<T>();
        }
        public async Task<int> PostAsync(string link,object modelClass)
        {
            var client = _httpClientFactory.CreateClient();

            //var jsonData = JsonConvert.SerializeObject(modelClass);

            //StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsJsonAsync($"https://localhost:44374/api/{link}", modelClass);
            if (responseMessage.IsSuccessStatusCode)
            {
                return 1;
            }
            return 0;
        }
        public async Task<int> PutAsync(string link, object modelClass)
        {
            var client = _httpClientFactory.CreateClient();

            //var jsonData = JsonConvert.SerializeObject(modelClass);

            //StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PutAsJsonAsync($"https://localhost:44374/api/{link}", modelClass);
            if (responseMessage.IsSuccessStatusCode)
            {
                return 1;
            }
            return 0;
        }
        public async Task<int> DeleteAsync(string link, int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.DeleteAsync($"https://localhost:44374/api/{link}/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return 1;
            }
            return 0;
        }
    }
}
