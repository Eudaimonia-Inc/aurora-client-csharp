namespace Aurora.Models.Responses
{
    public class MarketEvent
    {
        public Guid Id { get; set; }
        public string EventName { get; set; }
        public string EventText { get; set; }
        public DateTime CreateDate { get; set; }
        public long NewsItems { get; set; }
        public IEnumerable<string> Tickers { get; set; }
    }
}
