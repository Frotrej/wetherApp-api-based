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
        public static string SetCamelCaseEndpointNameFormatter<T>(string baseAddress, T options) where T : class
        {
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            string serializedOptions = JsonConvert.SerializeObject(options, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });

            var deserializedOptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedOptions);
            var endpoint = QueryHelpers.AddQueryString(baseAddress, deserializedOptions);

            return endpoint;
        }

        public static string SetSnakeCaseEndpointNameFormatter<T>(string baseAddress, T options) where T : class
        {
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            string serializedOptions = JsonConvert.SerializeObject(options, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });

            var deserializedOptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedOptions); 
            var endpoint = QueryHelpers.AddQueryString(baseAddress, deserializedOptions);

            return endpoint;
        }
    }
}
