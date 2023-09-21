namespace Aurora.Models.Requests
{
    public class GetAggregatesRequest
    {
        public Guid ForecastId { get; set; }
        public string Identifier { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Fields { get; set; }
        /// <summary>
        /// Interval in minutes
        /// </summary>
        public int Interval { get; set; }
    }
}
