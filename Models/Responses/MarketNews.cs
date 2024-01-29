namespace Aurora.Models.Responses
{
    public class MarketNews
    {
        public string ImageUrl { get; set; }
        public string NewsUrl { get; set; }
        public string Sentiment { get; set; }
        public string SourceName { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime CreateDate { get; set; }
        public List<string> MarketTopics { get; set; }
    }
}
