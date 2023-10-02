using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Helpers;
using Aurora.Models;
using Aurora.Models.Responses;

namespace Aurora.Clients.API
{
    public class ReferenceClient : BaseApiClent
    {
        public ReferenceClient(string apiKey) : base(apiKey) { }

        public async Task<ListedResponse<Ticker>> GetTickersAsync()
        {
            var uriString = Endpoints.GetTickersUrl;
            var uri = UriHelper.Build(uriString);

            return await GetAsync<ListedResponse<Ticker>>(uri);
        }
    }
}
