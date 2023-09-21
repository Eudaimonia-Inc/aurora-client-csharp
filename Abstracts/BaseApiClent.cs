using Aurora.Models;
using Newtonsoft.Json;

namespace Aurora.Abstracts
{
    public class BaseApiClent
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public BaseApiClent(string apiKey)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;
        }

        protected async Task<Response<T>?> GetAsync<T>(Uri uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri.AbsoluteUri);

            request.Headers.Add("X-Api-Key", _apiKey);

            var response = await _httpClient.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Response<T>>(result);
        }
    }
}
