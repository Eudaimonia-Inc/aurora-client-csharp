namespace Aurora.Models.Responses
{
    public class ForecastAggregatesLatest
    {
        public long From { get; set; }
        public long To { get; set; }
        public int Step { get; set; }
        public IEnumerable<Dictionary<string, double>> Aggregates { get; set; }
    }
}
