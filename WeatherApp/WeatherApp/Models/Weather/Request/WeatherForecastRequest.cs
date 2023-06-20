using DataAnnotationsExtensions;
using Newtonsoft.Json;

namespace WeatherApp.Models.Weather.Request
{
    public class WeatherForecastRequest
    {
        [JsonProperty(PropertyName = "latitude")]
        public float Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public float Longitude { get; set; }

        [JsonProperty(PropertyName = "current_weather")]
        public bool CurrentWeather { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        [Max(16)]
        [JsonProperty(PropertyName = "forecast_days")]
        public int ForecastDay { get; set; }
    }
}
