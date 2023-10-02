namespace Aurora.Models.Requests
{
    public class GetHistoricalAggregatesRequest
    {
        /// <summary>
        /// The size of the time window. In minutes, min: 1, max: 43800
        /// </summary>
        public int Interval { get; set; }
        /// <summary>
        /// The start of the aggregate time window. Date in millisecond timestamp.
        /// </summary>
        public long From { get; set; }
        /// <summary>
        /// The end of the aggregate time window. Date in millisecond timestamp.
        /// </summary>
        public long To { get; set; }
        /// <summary>
        /// The unique identifier of the currency pair. From '~/Api/Reference/Tickers' endpoint
        /// </summary>
        public string Identifier { get; set; }
    }
}
