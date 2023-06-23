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
        public string Name { get; set; }
        public string Language { get; set; }
    }
}
