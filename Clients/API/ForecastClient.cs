using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Helpers;
using Aurora.Models;
using Aurora.Models.Requests;
using Aurora.Models.Responses;

namespace Aurora.Clients.API
{
    public class ForecastClient : BaseApiClent
    {
        public ForecastClient(string apiKey) : base(apiKey) { }

        public async Task<ListedResponse<Forecast>> GetForecastsAsync(GetForecastsRequest request)
        {
            var uriString = string.Format(Endpoints.GetForecastsUrl, request.Identifier);
            var uri = UriHelper.Build(uriString);

            return await GetAsync<ListedResponse<Forecast>>(uri);
        }

        public async Task<ListedResponse<Column>> GetColumnsAsync(GetColumnsRequest request)
        {
            var uriString = string.Format(Endpoints.GetColumnsUrl, request.Identifier);
            var uri = UriHelper.Build(uriString);

            return await GetAsync<ListedResponse<Column>>(uri);
        }

        public async Task<ObjectResponse<Accuracy>> GetAccuracyAsync(GetAccuracyRequest request)
        {
            var uriString = string.Format(Endpoints.GetAccuracyUrl, request.Identifier);
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetAccuracyRequest.ForecastId), request.ForecastId.ToString() }
            };

            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ObjectResponse<Accuracy>>(uri);
        }

        public async Task<ListedResponse<ForecastAggregates>> GetAggregatesAsync(GetAggregatesRequest request)
        {
            var uriString = string.Format(Endpoints.GetAggregatesUrl, request.Identifier);
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetAggregatesRequest.ForecastId), request.ForecastId.ToString() },
                {nameof(GetAggregatesRequest.Interval), request.Interval.ToString() },
                {nameof(GetAggregatesRequest.From), request.From.ToString() },
                {nameof(GetAggregatesRequest.To), request.To.ToString() }
            };

            foreach (var column in request.Columns)
            {
                uriParameters.Add(nameof(GetAggregatesRequest.Columns), column);
            }

            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ListedResponse<ForecastAggregates>>(uri);
        }

        public async Task<ObjectResponse<ForecastAggregatesLatest>> GetLatestAggregatesAsync(GetLatestAggregatesRequest request)
        {
            var uriString = string.Format(Endpoints.GetAggregatesLatestUrl, request.Identifier);
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetLatestAggregatesRequest.ForecastId), request.ForecastId.ToString() },
                {nameof(GetLatestAggregatesRequest.Interval), request.Interval.ToString() }
            };

            foreach (var column in request.Columns)
            {
                uriParameters.Add(nameof(GetLatestAggregatesRequest.Columns), column);
            }

            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ObjectResponse<ForecastAggregatesLatest>>(uri);
        }
    }
}
