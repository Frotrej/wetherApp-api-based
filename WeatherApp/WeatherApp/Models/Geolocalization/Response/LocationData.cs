using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models.Geolocalization.Response
{
    public class LocationData
    {
        [JsonPropertyName("ide")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("postcodes")]
        public List<string> Postcodes { get; set; }
    }
}
