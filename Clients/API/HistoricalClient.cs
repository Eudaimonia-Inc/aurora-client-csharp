using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Helpers;
using Aurora.Models;
using Aurora.Models.Requests;
using Aurora.Models.Responses;

namespace Aurora.Clients.API
{
    public class HistoricalClient : BaseApiClent
    {
        public HistoricalClient(string apiKey) : base(apiKey) { }

        public async Task<ListedResponse<Aggregate>> GetAggregatesAsync(GetHistoricalAggregatesRequest request)
        {
            var uriString = string.Format(Endpoints.GetHistoricalAggregates, request.Identifier);
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetHistoricalAggregatesRequest.Interval), request.Interval.ToString() },
                {nameof(GetHistoricalAggregatesRequest.From), request.From.ToString() },
                {nameof(GetHistoricalAggregatesRequest.To), request.To.ToString() },
            };

            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ListedResponse<Aggregate>>(uri);
        }
    }
}
