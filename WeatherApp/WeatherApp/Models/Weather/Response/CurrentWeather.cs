using Newtonsoft.Json;
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
        public string Time { get; set; }
        public float Temperature { get; set; }
        public float Weathercode { get; set; }
        public float Windspeed { get; set; }
        public float WindDirection { get; set; }
        public int IsDay { get; set; }
    }
}
