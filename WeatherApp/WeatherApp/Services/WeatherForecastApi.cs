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
    public class WeatherForecastApi : IDisposable
    {
        private HttpClient httpClient;
        private const string BaseAddress = "https://api.open-meteo.com/v1/forecast?";
        private HttpResponseMessage response;
        public WeatherForecast Result { get; set; }

        public WeatherForecastApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseAddress);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task GetCurrentWeather(WeatherForecastOptions options)
        {
            var serializedOptions = JsonConvert.SerializeObject(options);
            var deserializedOptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedOptions);

            response = await httpClient.GetAsync(QueryHelpers.AddQueryString(BaseAddress, deserializedOptions));

            if (response.IsSuccessStatusCode)
            {
                Result = await response.Content.ReadFromJsonAsync<WeatherForecast>();
            }
            else
            {
                var statusCode = response.StatusCode;
                var erroMessage = await response.Content.ReadAsStringAsync();
                //Add Logger in the future
            }

        }
        public void Dispose()
        {
            httpClient.Dispose();
        }
    }
}

