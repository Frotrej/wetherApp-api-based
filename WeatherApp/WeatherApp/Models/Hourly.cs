using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    internal class Hourly
    {
        List<string> time { get; set; }
        List<string> apparent_temperature { get; set; }
    }
}
