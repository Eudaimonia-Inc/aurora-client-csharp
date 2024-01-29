namespace Aurora.Models.Responses
{
    public class AggregatePrice
    {
        public string Identifier { get; set; }
        public string DisplayName { get; set; }
        public string? CurrencySymbol { get; set; }
        public string? BaseCurrencySymbol { get; set; }
        public decimal? Price { get; set; }
        public double? Change { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Volume { get; set; }
        public string IconUrl { get; set; }
        public IEnumerable<decimal>? Chart { get; set; }
    }
}
