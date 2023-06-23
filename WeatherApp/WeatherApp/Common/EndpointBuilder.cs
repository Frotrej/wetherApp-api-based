using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using WeatherApp.Abstractions;

namespace WeatherApp.Common
{
    public static class EndpointBuilder
    {
        public static string BuildEndpoint<T>(string baseAddress, T options) where T : class
        {
            string serializedOptions = JsonConvert.SerializeObject(options, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            var deserializedOptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedOptions);

            var endpoint = QueryHelpers.AddQueryString(baseAddress, deserializedOptions);

            return endpoint;
        }
    }
}
