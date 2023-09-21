namespace Aurora.Models.Requests
{
    public class GetLatestAggregatesRequest
    {
        public Guid ForecastId { get; set; }
        public string Identifier { get; set; }
        public List<string> Fields { get; set; }

        /// <summary>
        /// Interval in minutes
        /// </summary>
        public int Interval { get; set; }
    }
}
