using DataAnnotationsExtensions;
using Newtonsoft.Json;

namespace WeatherApp.Models.Weather.Request
{
    public class WeatherForecastRequest
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool CurrentWeather { get; set; }
        public string Timezone { get; set; }
        public int ForecastDay { get; set; }
    }
}
