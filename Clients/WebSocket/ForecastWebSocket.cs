using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Models.Requests;
using Eudaimonia.Consumer.Application.Features.Forecast.Queries.GetTickerForecast;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Channels;

namespace Aurora.Clients.WebSocket
{
    public class ForecastWebSocket : BaseWebSocket
    {
        public ForecastWebSocket(string apiKey) : base(apiKey) { }

        public async Task<ChannelReader<ForecastAggregatesStream>> StreamAggregatesAsync(ForecastAggregatesStreamRequest request)
        {
            if (_connection == null || _connection.State != HubConnectionState.Connected)
            {
                await ConnectAsync(Endpoints.GetForecastAggregatesStreamUrl);
            }

            return await _connection.StreamAsChannelAsync<ForecastAggregatesStream>(Endpoints.AggregatesStreamMethodName, request.ForecastId, request.Identifier, request.Interval);
        }
    }
}
