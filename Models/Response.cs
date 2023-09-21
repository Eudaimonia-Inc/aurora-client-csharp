namespace Aurora.Models
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public IEnumerable<Error>? Errors { get; set; }
        public T? Result { get; set; }

        public Response(T result)
        {
            Result = result;
        }
    }
}
