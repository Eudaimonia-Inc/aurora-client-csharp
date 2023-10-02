namespace Aurora.Models.Requests
{
    public class GetForecastsRequest
    {
        /// <summary>
        /// The unique identifier of the currency pair. From '~/Api/Reference/Tickers' endpoint
        /// </summary>
        public string Identifier { get; set; }
    }
}
