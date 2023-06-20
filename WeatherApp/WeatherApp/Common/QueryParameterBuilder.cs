using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.Common
{
    public static class QueryParameterBuilder
    {
        public static string BuildQuery<T>(string baseAddress, T options)
        {
            var serializedOptions = JsonConvert.SerializeObject(options);
            var deserializedOptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedOptions);

            var query = QueryHelpers.AddQueryString(baseAddress, deserializedOptions);

            return query;
        }
    }
}
