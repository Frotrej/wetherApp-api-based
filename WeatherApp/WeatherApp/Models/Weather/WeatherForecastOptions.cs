using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Weather
{
    internal class WeatherForecastOptions
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool CurrentWeather { get; set; }
        public string Timezone { get; set; }
        [Max(16)]
        public int ForecastDay { get; set; }
    }
}
