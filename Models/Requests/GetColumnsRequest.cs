namespace Aurora.Models.Requests
{
    public class GetColumnsRequest
    {
        /// <summary>
        /// A unique identifier for the forecast, represented as a Guid. From '~/Api/Forecast/{Identifier}' endpoint
        /// </summary>
        public string Identifier { get; set; }
    }
}
