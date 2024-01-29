namespace Aurora.Models.Responses
{
    public class MarketSentiment
    {
        public Guid Id { get; set; }
        public double Sentiment { get; set; }
        public string Analysis { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
