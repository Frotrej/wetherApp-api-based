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
using WeatherApp.Models.Geolocalization.Request;
using WeatherApp.Models.Weather.Request;
using WeatherApp.Services;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WeatherForecastApi weatherForecastApi = new WeatherForecastApi();
        GeolocalizationApi geolocalizationApi = new GeolocalizationApi();
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

            GeolocalizationRequest geo = new GeolocalizationRequest
            {
                Name = "Richmond"
            };
            var b = await geolocalizationApi.GetGeolocalization(geo);

            var a = await weatherForecastApi.GetCurrentWeather(weather);
        }
    }
}
