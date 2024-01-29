using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Helpers;
using Aurora.Models;
using Aurora.Models.Requests;
using Aurora.Models.Responses;

namespace Aurora.Clients.API
{
    public class AggregatesClient : BaseApiClent
    {
        public AggregatesClient(string apiKey) : base(apiKey) { }

        public async Task<ListedResponse<AggregatePrice>> GetAggregatesPricesAsync(GetAggregatesPricesRequest request)
        {
            var uriString = Endpoints.GetAggregatesPricesUrl;
            var uriParameters = new Dictionary<string, string>
            {
                {nameof(GetAggregatesPricesRequest.PageNumber), request.PageNumber.ToString() },
                {nameof(GetAggregatesPricesRequest.PageSize), request.PageSize.ToString() },
                {nameof(GetAggregatesPricesRequest.OrderBy), request.OrderBy ?? string.Empty },
                {nameof(GetAggregatesPricesRequest.IsDesc), request.IsDesc?.ToString() ?? string.Empty },
            };

            var uri = UriHelper.Build(uriString, uriParameters);

            return await GetAsync<ListedResponse<AggregatePrice>>(uri);
        }
    }
}
