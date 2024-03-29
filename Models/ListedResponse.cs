﻿namespace Aurora.Models
{
    public class ListedResponse<T> : Response
    {
        public int Count { get; set; }
        public IEnumerable<T> Results { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}
