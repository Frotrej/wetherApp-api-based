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
        private HttpResponseMessage response;
        private WeatherForecast result;

        public WeatherForecastApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseAddress);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async void GetCurrentWeather(WeatherForecastOptions options)
        {
            var serializedOptions = JsonConvert.SerializeObject(options);
            var deserializedOptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedOptions);

            response = await httpClient.GetAsync(new Uri(QueryHelpers.AddQueryString(BaseAddress, deserializedOptions)));

            result = await response.Content.ReadFromJsonAsync<WeatherForecast>();
        }

    }
}

