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
using WeatherApp.Common;
using WeatherApp.Models.Geolocalization.Request;
using WeatherApp.Models.Geolocalization.Response;

namespace WeatherApp.Services
{
    public class GeolocalizationApi : IDisposable
    {
        private HttpClient httpClient;
        private const string BaseAddress = "https://api.open-meteo.com/v1/forecast?";
        private HttpResponseMessage response;
        private GeolocalizationResponse result;

        public GeolocalizationApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseAddress);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<GeolocalizationResponse> GetGeolocalization(GeolocalizationRequest options)
        {
            response = await httpClient.GetAsync(QueryParameterBuilder.BuildQuery(BaseAddress, options));
            
            if(response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<GeolocalizationResponse>();
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

