using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherApp.Abstractions;

namespace WeatherApp.Models.Weather.Response
{
    public class WeatherForecastResponse: IApiResponse
    {
        [JsonProperty(PropertyName = "latitude")]
        public float Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public float Longitude { get; set; }

        [JsonProperty(PropertyName = "elevation")]
        public float Elevation { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        [JsonProperty(PropertyName = "current_weather")]
        public CurrentWeather CurrentWeather { get; set; }
    }
}
