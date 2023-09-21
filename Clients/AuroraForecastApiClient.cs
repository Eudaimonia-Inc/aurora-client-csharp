using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Extensions;
using Aurora.Models;
using Aurora.Models.Requests;
using Aurora.Models.Responses;

namespace Aurora.Clients
{
    public class AuroraForecastApiClient : BaseApiClent
    {
        public AuroraForecastApiClient(string apiKey) : base(apiKey) { }

        public async Task<Response<List<GetForecastsResponse>>> GetForecastsAsync(GetForecastsRequest request)
        {
            var uriString = Endpoints.GetForecastsUrl;
            var uriParameters = new Dictionary<string, string>
            {
                {"Identifier", request.Identifier }
            };

            var uri = new Uri(uriString).UpsertParameter(uriParameters);

            return await GetAsync<List<GetForecastsResponse>>(uri);
        }

        public async Task<Response<List<GetAggregatesResponse>>> GetAggregatesAsync(GetAggregatesRequest request)
        {
            var uriString = string.Format(Endpoints.GetAggregatesUrl, request.ForecastId);
            var uriParameters = new Dictionary<string, string>
            {
                {"Identifier", request.Identifier },
                {"Interval", request.Interval.ToString() },
            };

            if (request.StartDate.HasValue)
            {
                uriParameters.Add("StartDate", request.StartDate.Value.ToString());
            }

            if (request.EndDate.HasValue)
            {
                uriParameters.Add("StartDate", request.EndDate.Value.ToString());
            }

            foreach (var field in request.Fields)
            {
                uriParameters.Add("Fields", field);
            }

            var uri = new Uri(uriString).UpsertParameter(uriParameters);

            return await GetAsync<List<GetAggregatesResponse>>(uri);
        }

        public async Task<Response<GetLatestAggregatesResponse>> GetLatestAggregatesAsync(GetLatestAggregatesRequest request)
        {
            var uriString = string.Format(Endpoints.GetLatestAggregatesUrl, request.ForecastId);
            var uriParameters = new Dictionary<string, string>
            {
                {"Identifier", request.Identifier },
                {"Interval", request.Interval.ToString() }
            };

            foreach (var field in request.Fields)
            {
                uriParameters.Add("Fields", field);
            }

            var uri = new Uri(uriString).UpsertParameter(uriParameters);

            return await GetAsync<GetLatestAggregatesResponse>(uri);
        }


        public async Task<Response<GetAccuracyResponse>> GetAccuracyAsync(GetAccuracyRequest request)
        {
            var uriString = string.Format(Endpoints.GetAccuracyUrl, request.ForecastId);
            var uriParameters = new Dictionary<string, string>
            {
                {"Identifier", request.Identifier }
            };

            var uri = new Uri(uriString).UpsertParameter(uriParameters);

            return await GetAsync<GetAccuracyResponse>(uri);
        }
    }
}
