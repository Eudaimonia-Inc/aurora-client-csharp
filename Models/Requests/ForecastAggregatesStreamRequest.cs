namespace Aurora.Models.Requests
{
    public class ForecastAggregatesStreamRequest
    {
        /// <summary>
        /// The unique identifier of the currency pair. From '~/Api/Reference/Tickers' endpoint
        /// </summary>
        public string Identifier { get; set; }
        /// <summary>
        /// The unique identifier of the currency pair. From '~/Api/Reference/Tickers' endpoint
        /// </summary>
        public Guid ForecastId { get; set; }
        /// <summary>
        /// The size of the time window. In minutes, min: 1, max: 43800
        /// </summary>
        public int Interval { get; set; }
    }
}
