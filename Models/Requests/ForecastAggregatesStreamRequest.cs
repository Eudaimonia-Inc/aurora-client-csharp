namespace Aurora.Models.Requests
{
    public class ForecastAggregatesStreamRequest
    {
        public string Identifier { get; set; }
        public Guid ForecastId { get; set; }
        /// <summary>
        /// Interval in minutes
        /// </summary>
        public int Interval { get; set; }
    }
}
