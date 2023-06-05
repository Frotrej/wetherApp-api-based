using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using WeatherApp.Weather;

namespace WeatherApp.Services
{
    public class WeatherForecastApi
    {
        private HttpClient httpClient;
        private const string BaseAddress = "https://api.open-meteo.com/v1/forecast?";
        private string AddressParameters { get; set; } //"latitude=49.98&longitude=18.95";
        private HttpResponseMessage response;

        public WeatherForecastApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseAddress);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //TODO: Europe/Warsaw -> Europer/Warsaw
        public async void GetCurrentWeather(WeatherForecastOptions weatherForecastOptions)
        {
            
            var json = JsonConvert.SerializeObject(weatherForecastOptions);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            var response = new Uri(QueryHelpers.AddQueryString(BaseAddress, dictionary));
            //HttpResponseMessage response = await httpClient.GetAsync(dictionary);

            //var a = response.Content.ReadAsStringAsync();
        }

    }
}

