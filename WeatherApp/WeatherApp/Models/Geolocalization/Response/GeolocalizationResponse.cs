using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherApp.Abstractions;

namespace WeatherApp.Models.Geolocalization.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GeolocalizationResponse: IApiResponse
    {
        public List<LocationData> Locations { get; set; }
    }
}
