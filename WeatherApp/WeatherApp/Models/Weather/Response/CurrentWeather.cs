using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models.Weather.Response
{
    public class CurrentWeather
    {
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "temperature")]
        public float Temperature { get; set; }

        [JsonProperty(PropertyName ="weathercode")]
        public float WeatherCode { get; set; }

        [JsonProperty(PropertyName = "windspeed")]
        public float WindSpeed { get; set; }

        [JsonProperty(PropertyName = "winddirection")]
        public float WindDirection { get; set; }

        [JsonProperty(PropertyName = "is_day")]
        public int IsDay { get; set; }
    }
}
