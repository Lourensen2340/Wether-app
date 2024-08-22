using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private string apiKey = "fe8d875ea151a6290dd30c0f8249dbf2"; // Замените YOUR_API_KEY на ваш ключ API

        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string city = textBox1.Text;
            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Please enter a city name.");
                return;
            }

            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=ru";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    var weatherData = JsonConvert.DeserializeObject<WeatherResponse>(responseBody);

                    DisplayWeatherData(weatherData);
                    artWeather(weatherData);
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Request error: {ex.Message}");
                }
            }
        }

        private void DisplayWeatherData(WeatherResponse weatherData)
        {
            labelTemp.Text = $"Temperature: {weatherData.Main.Temp}°C";
            labelFeelsLike.Text = $"Feels Like: {weatherData.Main.Feels_Like}°C";
            labelTempMin.Text = $"Temp Min: {weatherData.Main.Temp_Min}°C";
            labelTempMax.Text = $"Temp Max: {weatherData.Main.Temp_Max}°C";
            labelPressure.Text = $"Pressure: {weatherData.Main.Pressure} hPa";
            labelHumidity.Text = $"Humidity: {weatherData.Main.Humidity}%";
            labelVisibility.Text = $"Visibility: {weatherData.Visibility} m";
            labelWindSpeed.Text = $"Wind Speed: {weatherData.Wind.Speed} m/s";
            labelWindDirection.Text = $"Wind Direction: {weatherData.Wind.Deg}°";
            labelWindGust.Text = $"Wind Gust: {weatherData.Wind.Gust} m/s";
            labelCloudiness.Text = $"Cloudiness: {weatherData.Clouds.All}%";
            labelDescription.Text = $"Description: {weatherData.Weather[0].Description}";
            labelCountry.Text = $"Country: {weatherData.Sys.Country}";
            labelSunrise.Text = $"Sunrise: {UnixTimeStampToDateTime(weatherData.Sys.Sunrise)}";
            labelSunset.Text = $"Sunset: {UnixTimeStampToDateTime(weatherData.Sys.Sunset)}";
        }

        private DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public class WeatherResponse
        {
            public Coord Coord { get; set; }
            public List<Weather> Weather { get; set; }
            public string Base { get; set; }
            public Main Main { get; set; }
            public int Visibility { get; set; }
            public Wind Wind { get; set; }
            public Clouds Clouds { get; set; }
            public int Dt { get; set; }
            public Sys Sys { get; set; }
            public int Timezone { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cod { get; set; }
        }

        public class Coord
        {
            public float Lon { get; set; }
            public float Lat { get; set; }
        }

        public class Weather
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class Main
        {
            public float Temp { get; set; }
            public float Feels_Like { get; set; }
            public float Temp_Min { get; set; }
            public float Temp_Max { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public int Sea_Level { get; set; }
            public int Grnd_Level { get; set; }
        }

        public class Wind
        {
            public float Speed { get; set; }
            public int Deg { get; set; }
            public float Gust { get; set; }
        }

        public class Clouds
        {
            public int All { get; set; }
        }

        public class Sys
        {
            public int Type { get; set; }
            public int Id { get; set; }
            public string Country { get; set; }
            public int Sunrise { get; set; }
            public int Sunset { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }


        

        private void artWeather(WeatherResponse weatherData)
        {
            if (weatherData?.Main?.Temp != null)
            {
                double SpeedCity;
                if (double.TryParse($"{weatherData.Wind.Speed}", out SpeedCity))
                {
                    if (SpeedCity > 0)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\Cloudy.jpg");
                    }
                    else if (SpeedCity <= 0)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\hurrycane.jpg");
                    }
                }
                else
                {
                    MessageBox.Show("Temperature data is not in a valid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Temperature data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (weatherData?.Main?.Temp != null)
            {
                string DescriptionCity = weatherData.Weather[0].Description;
               
                {
                    if (DescriptionCity == "облачно с прояснениями" || DescriptionCity == "переменная облачность")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\Cloudy.jpg");
                    }
                    else if (DescriptionCity == "ясно")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\synny.jpg");
                    }
                    else if (DescriptionCity == "ливень")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\Heavy_raining.jpg");
                    }
                    else if (DescriptionCity == "небольшой проливной дождь")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\rain.png");
                    }
                    else if (DescriptionCity == "гроза")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\thunder.jpg");
                    }
                    else if (DescriptionCity == "cнег")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\snow-cover.jpg");
                    }
                    else if (DescriptionCity == "туман" || DescriptionCity == "дымка")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\OneDrive\\Рабочий стол\\whether pic\\foggy.jpg");
                    }


                }

                
            }
            else
            {
                MessageBox.Show("Temperature data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
//perfect code
// first code
