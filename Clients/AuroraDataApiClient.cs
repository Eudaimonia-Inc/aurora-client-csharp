using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Models;
using Aurora.Models.Responses;

namespace Aurora.Clients
{
    public class AuroraDataApiClient : BaseApiClent
    {
        public AuroraDataApiClient(string apiKey) : base(apiKey) { }

        public async Task<Response<List<GetIdentifiersResponse>>> GetIdentifiersAsync()
        {
            var uriString = Endpoints.GetIdentifiersUrl;
            var uri = new Uri(uriString);

            return await GetAsync<List<GetIdentifiersResponse>>(uri);
        }

        public async Task<Response<List<GetColumnsResponse>>> GetColumnsAsync()
        {
            var uriString = Endpoints.GetColumnsUrl;
            var uri = new Uri(uriString);

            return await GetAsync<List<GetColumnsResponse>>(uri);
        }
    }
}
