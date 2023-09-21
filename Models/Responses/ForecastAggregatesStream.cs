namespace Eudaimonia.Consumer.Application.Features.Forecast.Queries.GetTickerForecast;

public class ForecastAggregatesStream
{
    public long From { get; set; }
    public long To { get; set; }
    public int Step { get; set; }
    public IEnumerable<Dictionary<string, double>> Aggregates { get; set; }
}