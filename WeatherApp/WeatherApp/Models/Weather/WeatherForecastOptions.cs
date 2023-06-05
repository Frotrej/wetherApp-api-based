using DataAnnotationsExtensions;
using Newtonsoft.Json;

namespace WeatherApp.Weather
{
    public class WeatherForecastOptions
    {
        [JsonProperty(PropertyName =("latitude"))]
        public float Latitude { get; set; }

        [JsonProperty(PropertyName =("longitude"))]
        public float Longitude { get; set; }

        [JsonProperty(PropertyName =("current_weather"))]
        public bool CurrentWeather { get; set; }

        [JsonProperty(PropertyName =("timezone"))]
        public string Timezone { get; set; }

        [Max(16)]
        [JsonProperty(PropertyName =("forecast_days"))]
        public int ForecastDay { get; set; }
    }
}
