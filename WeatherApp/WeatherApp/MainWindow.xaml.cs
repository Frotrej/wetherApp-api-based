using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApp.Models.Weather.Request;
using WeatherApp.Services;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //TODO:
        //Ustandaryzować proces konwertowania na JSON ponieważ [JsonPropertyName("")] działa w responsie
        //[JsonProperty(PropertyName = "")] działa w requescie
        //Wynika to z tego że QueryParameterBuilder i Request działają z biblioteką Newtonsoft.Json; a Response i Api z systemowymi bibliotekami
        WeatherForecastApi weatherForecastApi = new WeatherForecastApi();
		public MainWindow()
        {
            InitializeComponent();
        }

        private async void GetWeather_Click(object sender, RoutedEventArgs e)
        {
            WeatherForecastRequest weather = new WeatherForecastRequest
            {
                CurrentWeather = true,
                Timezone = "Europe/Warsaw",
                ForecastDay = 1,
                Latitude = 49.98f,
                Longitude = 18.95f
            };

            var a = await weatherForecastApi.GetCurrentWeather(weather);
        }
    }
}
