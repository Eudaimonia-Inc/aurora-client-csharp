namespace Aurora.Models
{
    public class ObjectResponse<T> : Response
    {
        public T Results { get; set; }
    }
}
