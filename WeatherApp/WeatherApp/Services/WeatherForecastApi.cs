using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Web;
using WeatherApp.Common;
using WeatherApp.Models.Weather.Request;
using WeatherApp.Models.Weather.Response;

namespace WeatherApp.Services
{
    public class WeatherForecastApi:IDisposable
    {
        private HttpClient httpClient;
        private const string BaseAddress = "https://api.open-meteo.com/v1/forecast?";
        private HttpResponseMessage response;
        private WeatherForecastResponse result;

        public WeatherForecastApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseAddress);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<WeatherForecastResponse> GetCurrentWeather(WeatherForecastRequest options)
        {
            response = await httpClient.GetAsync(QueryParameterBuilder.BuildQuery(BaseAddress, options));
            
            if(response.IsSuccessStatusCode)
            {
                var resultAsString = await response.Content.ReadAsStringAsync();
                result =  JsonConvert.DeserializeObject<WeatherForecastResponse>(resultAsString);
                return result;
            }
            else
            {
                var statusCode = response.StatusCode;
                var errorMessage = await response.Content.ReadAsStringAsync();
                //Add Logger in the future
                return null;
            }
        }
        public void Dispose()
        {
            httpClient.Dispose();
        }
    }
}

