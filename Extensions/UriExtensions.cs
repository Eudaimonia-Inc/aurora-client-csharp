using System.Web;

namespace Aurora.Extensions
{
    public static class UriExtensions
    {
        public static Uri UpsertParameter(this Uri url, Dictionary<string, string> parameters)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            foreach (var parameter in parameters)
            {
                if (query.AllKeys.Contains(parameter.Key))
                {
                    query[parameter.Key] = parameter.Value;
                }
                else
                {
                    query.Add(parameter.Key, parameter.Value);
                }
            }

            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }
    }
}
