namespace Aurora.Models.Requests
{
    public class GetMarketNewsEventsRequest : PagedRequest
    {
        public string Ticker { get; set; }
    }
}
