using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherApp.Abstractions;

namespace WeatherApp.Models.Geolocalization.Request
{
    public class GeolocalizationRequest: IApiRequest
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
    }
}
