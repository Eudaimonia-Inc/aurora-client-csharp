namespace Aurora.Models.Requests
{
    public class GetMarketSentimentRequest : PagedRequestBase
    {
        public string Ticker { get; set; }
    }
}
