using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;

namespace Aurora.Abstracts
{
    public class BaseWebSocket : IAsyncDisposable
    {
        protected HubConnection? _connection;
        protected readonly string? _apiKey;

        public BaseWebSocket(string apiKey) => _apiKey = apiKey;

        protected async Task ConnectAsync(string url)
        {
            _connection = new HubConnectionBuilder()
               .WithUrl(url, opts => opts.AccessTokenProvider = () => Task.FromResult(_apiKey))
               .WithAutomaticReconnect()
               .AddJsonProtocol()
               .Build();

            await _connection.StartAsync();
        }

        public HubConnection? GetConnection() => _connection;

        public async ValueTask DisposeAsync()
        {
            if (_connection != null)
            {
                await _connection.StopAsync();
            }
        }
    }
}
