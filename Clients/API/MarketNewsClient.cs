using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Helpers;
using Aurora.Models;
using Aurora.Models.Requests;
using Aurora.Models.Responses;

namespace Aurora.Clients.API
{
    public class MarketNewsClient : BaseApiClent
    {
        public MarketNewsClient(string apiKey) : base(apiKey) { }

        public async Task<ListedResponse<MarketNews>> GetMarketNewsAsync(GetMarketNewsRequest request)
        {
            var uriString = Endpoints.GetMarketNewsUrl;
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetMarketNewsRequest.PageNumber), request.PageNumber.ToString() },
                {nameof(GetMarketNewsRequest.PageSize), request.PageSize.ToString() },
                {nameof(GetMarketNewsRequest.OrderBy), request.OrderBy ?? string.Empty },
                {nameof(GetMarketNewsRequest.IsDesc), request.IsDesc?.ToString() ?? string.Empty },
                {nameof(GetMarketNewsRequest.FilterBy), request.FilterBy ?? string.Empty },
                {nameof(GetMarketNewsRequest.Filter), request.Filter ?? string.Empty },
                {nameof(GetMarketNewsRequest.Type), request.Type },
            };
            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ListedResponse<MarketNews>>(uri);
        }

        public async Task<ListedResponse<string>> GetMarketNewsTypesAsync()
        {
            var uriString = Endpoints.GetMarketNewsTypesUrl;
            var uri = UriHelper.Build(uriString);

            return await GetAsync<ListedResponse<string>>(uri);
        }

        public async Task<ListedResponse<MarketEvent>> GetMarketNewsEventsAsync(GetMarketNewsEventsRequest request)
        {
            var uriString = Endpoints.GetMarketNewsEventsUrl;
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetMarketNewsEventsRequest.PageNumber), request.PageNumber.ToString() },
                {nameof(GetMarketNewsEventsRequest.PageSize), request.PageSize.ToString() },
                {nameof(GetMarketNewsEventsRequest.OrderBy), request.OrderBy ?? string.Empty },
                {nameof(GetMarketNewsEventsRequest.IsDesc), request.IsDesc?.ToString() ?? string.Empty },
                {nameof(GetMarketNewsEventsRequest.FilterBy), request.FilterBy ?? string.Empty },
                {nameof(GetMarketNewsEventsRequest.Filter), request.Filter ?? string.Empty },
                {nameof(GetMarketNewsEventsRequest.Ticker), request.Ticker },
            };
            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ListedResponse<MarketEvent>>(uri);
        }
    }
}
