using DataAnnotationsExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WeatherApp.Abstractions;

namespace WeatherApp.Models.Weather.Request
{
    public class WeatherForecastRequest: IApiRequest
    {
        [JsonProperty(PropertyName = "latitude")]
        public float Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public float Longitude { get; set; }

        [JsonProperty(PropertyName = "current_weather")]
        public bool CurrentWeather { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        [JsonProperty(PropertyName = "forecast_day")]
        public int? ForecastDay { get; set; }
    }
}
