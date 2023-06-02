using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Geo
{
    internal class GeocodingOptions
    {
        public string Name { get; init; }
        public string Language { get; init; }

        public GeocodingOptions(string name, string language)
        {
            Name= name;
            Language= language;
        }
    }
}
