namespace Aurora.Models.Responses
{
    public class ForecastAggregates
    {
        public long From { get; set; }
        public long To { get; set; }
        public int Step { get; set; }
        public List<Dictionary<string, double>> Aggregates { get; set; }
    }
}
