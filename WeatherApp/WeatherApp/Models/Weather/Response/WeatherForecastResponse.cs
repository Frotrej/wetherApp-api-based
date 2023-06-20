using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models.Weather.Response
{
    public class WeatherForecastResponse
    {
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }

        [JsonPropertyName("elevation")]
        public float Elevation { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonProperty(PropertyName = "current_weather")]
        public CurrentWeather CurrentWeather { get; set; }
    }
}
