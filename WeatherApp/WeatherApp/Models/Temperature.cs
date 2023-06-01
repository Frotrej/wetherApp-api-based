using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    internal class Temperature
    {
        string latitude { get; set; }
        string longitude { get; set; }
        string generationtime_ms { get; set; }
        string utc_offset_seconds { get; set; }
        string timezone { get; set; }
        string timezone_abbreviation { get; set; }
        string elevation { get; set; }
        Hourly hourly { get; set; }
    }
}

//https://api.open-meteo.com/v1/forecast?latitude=49.98&longitude=18.95&hourly=apparent_temperature&daily=sunset&forecast_days=1&timezone=auto