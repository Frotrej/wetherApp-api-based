using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace WeatherApp.Common
{
    public static class QueryParameterBuilder
    {
        public static string BuildQuery<T>(string baseAddress, T options)
        {
            //Converting CamelCase to snake_case
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            string serializedObject = JsonConvert.SerializeObject(options, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });
            //
            var deserializedObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedObject); ;
            var query = QueryHelpers.AddQueryString(baseAddress, deserializedObject);

            return query;
        }
    }
}
