using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Geo
{
    public class GeocodingApiResponse
    {
        [JsonPropertyName("results")]
        public List<LocationData> Locations { get; set; }
    }
}
