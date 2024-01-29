using System.Web;

namespace Aurora.Helpers
{
    public class UriHelper
    {
        public static Uri Build(string uriString, Dictionary<string, string>? parameters = null)
        {
            var uri = new Uri(uriString);
            var uriBuilder = new UriBuilder(uri);

            if (parameters != null)
            {
                var query = HttpUtility.ParseQueryString(uriBuilder.Query);

                foreach (var parameter in parameters)
                {
                    if (string.IsNullOrEmpty(parameter.Value))
                    {
                        continue;
                    }

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
            }

            return uriBuilder.Uri;
        }
    }
}
