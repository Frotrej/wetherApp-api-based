using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models.Geolocalization.Response
{
    public class GeolocalizationResponse
    {
        [JsonPropertyName("results")]
        public List<LocationData> Locations { get; set; }
    }
}
