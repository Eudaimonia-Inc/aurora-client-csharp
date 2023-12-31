﻿namespace Aurora.Models.Requests
{
    public class GetAggregatesRequest
    {
        /// <summary>
        /// The unique identifier of the currency pair. From '~/Api/Reference/Tickers' endpoint
        /// </summary>
        public Guid ForecastId { get; set; }
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
        /// <summary>
        /// The columns key holds an array of objects that describe the columns or attributes associated with the crypto asset's data. 
        /// From '~/Api/Forecast/{Identifier}/Columns' endpoint
        /// </summary>
        public List<string> Columns { get; set; }
    }
}
