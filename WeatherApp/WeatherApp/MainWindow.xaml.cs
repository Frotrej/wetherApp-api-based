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
using WeatherApp.Services;
using WeatherApp.Weather;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		WeatherForecastApi weatherForecastApi = new WeatherForecastApi();
		public MainWindow()
        {
            InitializeComponent();
            
           
        }

		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			WeatherForecastOptions weather = new WeatherForecastOptions
			{
				CurrentWeather = true,
				Timezone = "Europe/Warsaw",
				ForecastDay = 1,
				Latitude = 49.98f,
				Longitude = 18.95f
			};
			await weatherForecastApi.GetCurrentWeather(weather);
			var a = JsonConvert.SerializeObject(weatherForecastApi.Result, Formatting.Indented);
			TbResult.Text = a;
		}
	}
}
