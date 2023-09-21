using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Models.Requests;
using eudaimonia.datasync.application.Models.Dtos;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Channels;

namespace Aurora.Clients
{
    public class AuroraDataWebSocketClient : BaseWebSocketClient
    {
        public AuroraDataWebSocketClient(string apiKey) : base(apiKey) { }

        public async Task<ChannelReader<DataAggregateStream>> AggregatesStreamAsync(DataAggregatesStreamRequest request)
        {
            if (_connection == null || _connection.State != HubConnectionState.Connected)
            {
                await ConnectAsync(Endpoints.GetDataAggregatesStreamUrl);
            }

            return await _connection.StreamAsChannelAsync<DataAggregateStream>(Endpoints.AggregatesStreamMethodName, request.Identifier);
        }
    }
}
