namespace Aurora.Constants
{
    public class Endpoints
    {
        public const string BaseUrl = "https://auroracapi.eaift.com";
        public const string Api = "/api";
        public const string WS = "/hubs";

        public const string GetIdentifiersUrl = BaseUrl + Api + "/Data/Identifiers";
        public const string GetColumnsUrl = BaseUrl + Api + "/Data/Columns";

        public const string GetForecastsUrl = BaseUrl + Api + "/Forecast";
        public const string GetAggregatesUrl = BaseUrl + Api + "/Forecast/{0}/aggregates";
        public const string GetLatestAggregatesUrl = BaseUrl + Api + "/Forecast/{0}/aggregates/latest";
        public const string GetAccuracyUrl = BaseUrl + Api + "/Forecast/{0}/accuracy";

        public const string GetDataAggregatesStreamUrl = BaseUrl + WS + "/crypto";
        public const string GetForecastAggregatesStreamUrl = BaseUrl + WS + "/forecast";
        public const string AggregatesStreamMethodName = "Aggregates";
    }
}
