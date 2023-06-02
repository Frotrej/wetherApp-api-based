using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Weather
{
    internal class CurrentWeather
    {
        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("temperature")]
        public float Temperature { get; set; }

        [JsonPropertyName("weathercode")]
        public float Weathercode { get; set; }

        [JsonPropertyName("windspeed")]
        public float Windspeed { get; set; }

        [JsonPropertyName("winddirection")]
        public float WindDirection { get; set; }

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }
    }
}
