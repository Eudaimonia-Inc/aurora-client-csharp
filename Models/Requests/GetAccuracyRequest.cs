namespace Aurora.Models.Requests
{
    public class GetAccuracyRequest
    {
        public Guid ForecastId { get; set; }
        public string Identifier { get; set; }
    }
}
