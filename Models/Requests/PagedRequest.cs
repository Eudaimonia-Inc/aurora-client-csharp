namespace Aurora.Models.Requests
{
    public class PagedRequest : PagedRequestBase
    {
        public string? OrderBy { get; set; } = null;
        public bool? IsDesc { get; set; } = null;
        public string? FilterBy { get; set; } = null;
        public string? Filter { get; set; } = null;
    }
}
