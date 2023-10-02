using Aurora.Abstracts;
using Aurora.Constants;
using Aurora.Models.Requests;
using eudaimonia.datasync.application.Models.Dtos;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Channels;

namespace Aurora.Clients.WebSocket
{
    public class CryptoWebSocket : BaseWebSocket
    {
        public CryptoWebSocket(string apiKey) : base(apiKey) { }

        public async Task<ChannelReader<CryptoAggregateStream>> StreamAggregatesAsync(CryptoAggregatesStreamRequest request)
        {
            if (_connection == null || _connection.State != HubConnectionState.Connected)
            {
                await ConnectAsync(Endpoints.GetDataAggregatesStreamUrl);
            }

            return await _connection.StreamAsChannelAsync<CryptoAggregateStream>(Endpoints.AggregatesStreamMethodName, request.Identifier);
        }
    }
}
