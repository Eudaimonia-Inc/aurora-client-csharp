namespace Aurora.Models.Requests
{
    public class PagedRequestBase
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 15;
    }
}
