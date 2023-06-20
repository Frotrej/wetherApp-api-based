using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.Geolocalization.Request
{
    public class GeolocalizationRequest
    {
        public string Name { get; init; }
        public string Language { get; init; }

        public GeolocalizationRequest(string name, string language)
        {
            Name = name;
            Language = language;
        }
    }
}
