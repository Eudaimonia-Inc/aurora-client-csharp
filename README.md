# Aurora C# Client

The Aurora C# Client is a .NET library that empowers developers to seamlessly interact with the Aurora REST and WebSocket API. With this library, you can effortlessly access data, retrieve forecast information, and execute various operations using both HTTP requests and WebSocket connections.
To get started, please see the [Getting Started](https://aurora.eaift.com/#/docs) section in our documentation

## Table of Contents

-   [Installation](#installation)
-   [Usage](#usage)
    -   [REST API](#rest-api)
    -   [WebSocket API](#websocket-api)

## Installation

Install it using npm or yarn:

```bash
dotnet add package <PACKAGE_NAME>
```

## Usage

Our WebSocket and REST APIs are designed around entitlements, ensuring you connect to the right hubs and access the data you need. For personalized examples, including your API key and entitlements, please [login](https://aurora.eaift.com/#/signin).

To utilize the Crypto WebSocket and REST endpoints, there are two key prerequisites that need to be met:

1. **Subscription Plan**: To access our REST API and WebSocket endpoints, you need an active subscription plan. Ensure that your subscription plan is up-to-date and grants you access to the specific API and WebSocket hubs you intend to use.
2. **API Key**: You must possess a valid API key, which serves as your authentication token for accessing both the REST API and WebSocket endpoints. If you haven't generated an API key yet, you can create one by visiting the [API Key creation page](https://aurora.eaift.com/#/api-keys).

Once you have an API key and an active subscription plan, you are ready to start using both the REST API and WebSocket endpoints to access real-time cryptocurrency data and Forecast insights.

### REST API
The Aurora C# Client provides an intuitive way to interact with the Aurora REST API.

```C#
using Aurora.Clients.API;

// Create a new API client instance with your API key
var apiKey = "your-api-key";

// Use to retrieve identifiers
var client = new ReferenceClient(apiKey);
var result = await client.GetTickersAsync();

// Use to retrieve historical aggregates
var client = new HistoricalClient(apiKey);
var request = new GetHistoricalAggregatesRequest { Identifier = "X:BTCUSD", Interval = 1, From = 1383528120000, To = 1383535680000 };
var result = await client.GetAggregatesAsync();

// Use to retrieve forecast data
var client = new ForecastClient(apiKey);
var request = new GetForecastsRequest { Identifier = "X:BTCUSD" };
var result = await client.GetForecastsAsync(request);

// Use to retrieve columns data
var client = new ForecastClient(apiKey);
var request = new GetColumnsRequest { Identifier = "X:BTCUSD" };
var result = await client.GetColumnsAsync(request);

// Use to retrieve accuracy data
var client = new ForecastClient(apiKey);
var request = new GetAccuracyRequest { Identifier = "X:BTCUSD", ForecastId = new Guid("forecast-id") };
var result = await client.GetAccuracyAsync(request);

// Use to retrieve forecast aggregates
var client = new ForecastClient(apiKey);
var request = new GetAggregatesRequest { Identifier = "X:BTCUSD", Interval = 1, From = 1383528120000, To = 1883535680000, ForecastId = new Guid("forecast-id"), Columns = new List<string> { "Close" } };
var result = await client.GetAggregatesAsync(request);

// Use to retrieve the latest forecast aggregates
var client = new ForecastClient(apiKey);
var request = new GetLatestAggregatesRequest new GetLatestAggregatesRequest { Identifier = "X:BTCUSD", Interval = 1, ForecastId = new Guid("forecast-id"), Columns = new List<string> { "Close" } };
var result = await client.GetLatestAggregatesAsync(request);
```

### WebSocket API

The WebSocket client allows real-time interactions with the Aurora WebSocket API.

Stream real-time crypto aggregates for a given identifier.
```C#
using Aurora.Clients.WebSocket;

// Create a new WebSocket client instance with your API key
var apiKey = "your-api-key";
var wsClient = new CryptoWebSocket(apiKey);

// Connect to crypto hub
var request = new CryptoAggregatesStreamRequest { Identifier = "X:BTCUSD" };
var stream = await wsClient.StreamAggregatesAsync(request);

// Listen stream for data
while (await stream.WaitToReadAsync())
{
    await foreach (var aggregateWS in stream.ReadAllAsync())
    {
        Console.WriteLine(aggregateWS.Time + "\t" + aggregateWS.High + "\t" + aggregateWS.Low);
    }
}

```

Stream real-time forecast aggregates for a given identifier.
```C#
using Aurora.Clients.WebSocket;

// Create a new WebSocket client instance with your API key
var apiKey = "your-api-key";
var wsClient = new ForecastWebSocket(apiKey);

// Connect to forecast hub
var request = new ForecastAggregatesStreamRequest { Identifier = "X:BTCUSD", ForecastId = new Guid("forecast-id"), Interval = 1 };
var stream = await wsClient.StreamAggregatesAsync(request);

// Listen stream for data
while (await stream.WaitToReadAsync())
{
    await foreach (var aggregateWS in stream.ReadAllAsync())
    {
        Console.WriteLine(aggregateWS.Time + "\t" + aggregateWS.High + "\t" + aggregateWS.Low);
    }
}

```
