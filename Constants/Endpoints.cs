namespace Aurora.Constants
{
    public class Endpoints
    {
        //public const string BaseUrl = "https://auroracapi.eaift.com";
        public const string BaseUrl = "https://slrs31easconsumerservices.eaift.com";
        public const string Api = "/Api";
        public const string WS = "/hubs";

        public const string GetForecastsUrl = BaseUrl + Api + "/Forecast/{0}";
        public const string GetColumnsUrl = BaseUrl + Api + "/Forecast/{0}/Columns";
        public const string GetAccuracyUrl = BaseUrl + Api + "/Forecast/{0}/Accuracy";
        public const string GetAggregatesUrl = BaseUrl + Api + "/Forecast/{0}/Aggregates";
        public const string GetAggregatesLatestUrl = BaseUrl + Api + "/Forecast/{0}/Aggregates/Latest";

        public const string GetHistoricalAggregates = BaseUrl + Api + "/Historical/{0}/Aggregates";

        public const string GetTickersUrl = BaseUrl + Api + "/Reference/Tickers";

        public const string GetDataAggregatesStreamUrl = BaseUrl + WS + "/crypto";
        public const string GetForecastAggregatesStreamUrl = BaseUrl + WS + "/forecast";
        public const string AggregatesStreamMethodName = "Aggregates";
    }
}
