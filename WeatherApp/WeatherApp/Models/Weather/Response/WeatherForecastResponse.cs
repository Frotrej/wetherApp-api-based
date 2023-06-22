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
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Elevation { get; set; }
        public string Timezone { get; set; }
        public CurrentWeather CurrentWeather { get; set; }
    }
}
