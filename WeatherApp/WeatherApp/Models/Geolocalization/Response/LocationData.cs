﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.Geolocalization.Response
{
    public class LocationData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public List<string> Postcodes { get; set; }
    }
}
