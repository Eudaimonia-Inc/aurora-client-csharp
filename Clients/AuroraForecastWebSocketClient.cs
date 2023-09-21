using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Models.Requests;
using Eudaimonia.Consumer.Application.Features.Forecast.Queries.GetTickerForecast;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Channels;

namespace Aurora.Clients
{
    public class AuroraForecastWebSocketClient : BaseWebSocketClient
    {
        public AuroraForecastWebSocketClient(string apiKey) : base(apiKey) { }

        public async Task<ChannelReader<ForecastAggregatesStream>> AggregatesStreamAsync(ForecastAggregatesStreamRequest request)
        {
            if (_connection == null || _connection.State != HubConnectionState.Connected)
            {
                await ConnectAsync(Endpoints.GetForecastAggregatesStreamUrl);
            }

            return await _connection.StreamAsChannelAsync<ForecastAggregatesStream>(Endpoints.AggregatesStreamMethodName, _apiKey, request.ForecastId, request.Identifier, request.Interval);
        }
    }
}
