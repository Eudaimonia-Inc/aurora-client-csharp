﻿namespace Aurora.Models.Requests
{
    public class GetAccuracyRequest
    {
        /// <summary>
        /// The unique identifier of the currency pair. From '~/Api/Reference/Tickers' endpoint
        /// </summary>
        public Guid ForecastId { get; set; }
        /// <summary>
        /// A unique identifier for the forecast, represented as a Guid. From '~/Api/Forecast/{Identifier}' endpoint
        /// </summary>
        public string Identifier { get; set; }
    }
}
