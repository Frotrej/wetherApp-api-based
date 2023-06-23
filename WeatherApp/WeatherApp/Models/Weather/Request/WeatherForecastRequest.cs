using DataAnnotationsExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WeatherApp.Abstractions;

namespace WeatherApp.Models.Weather.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class WeatherForecastRequest: IApiRequest
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool CurrentWeather { get; set; }
        public string Timezone { get; set; }
        public int ForecastDay { get; set; }
    }
}
