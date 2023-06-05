using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public MainWindow()
        {
            InitializeComponent();
            WeatherForecastApi weatherForecastApi = new WeatherForecastApi();

            WeatherForecastOptions weather = new WeatherForecastOptions{ 
                CurrentWeather=true,
                Timezone = "Europe/Warsaw",
                ForecastDay=1,
                Latitude=49.98f,
                Longitude=18.95f
            };


            weatherForecastApi.GetCurrentWeather(weather);
        }
    }
}
