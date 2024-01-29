using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Helpers;
using Aurora.Models;
using Aurora.Models.Requests;
using Aurora.Models.Responses;

namespace Aurora.Clients.API
{
    public class MarketSentimentClient : BaseApiClent
    {
        public MarketSentimentClient(string apiKey) : base(apiKey) { }

        public async Task<ListedResponse<MarketSentiment>> GetMarketSentimentAsync(GetMarketSentimentRequest request)
        {
            var uriString = string.Format(Endpoints.GetMarketSentimentUrl, request.Ticker);
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetMarketSentimentRequest.PageNumber), request.PageNumber.ToString() },
                {nameof(GetMarketSentimentRequest.PageSize), request.PageSize.ToString() },
                {nameof(GetMarketSentimentRequest.Ticker), request.Ticker.ToString() },
            };
            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ListedResponse<MarketSentiment>>(uri);
        }
    }
}
