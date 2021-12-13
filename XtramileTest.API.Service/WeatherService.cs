using System;
using System.Linq;
using XtramileTest.Core.Models;

namespace XtramileTest.API.Service
{
    public interface IWeatherService
    {
        double ConvertFToC(double temperature);
        Weather GetCityWeather(string city);
    }
    public class WeatherService : IWeatherService
    {
        public double ConvertFToC(double temperature)
        {
            double tempC = (temperature - 32) * 5 / 9;
            return tempC;
        }

        public Weather GetCityWeather(string city)
        {
            string[] SkyCondition = new[] { "Clear", "Clouds" };
            var rng = new Random();
            var tempF = rng.Next(-10, 130);
            var result = new Weather()
            {
                name = city,
                date = DateTime.Now.AddDays(rng.Next(1, 5)).ToString("dd-MM-yyyy hh:mm:ss"),
                temperatureF = tempF,
                temperatureC = ConvertFToC(tempF),
                skyCondition = SkyCondition[rng.Next(0, SkyCondition.Length - 1)],
                coord = new Location() { lat = rng.Next(0, 130), lon = rng.Next(-40, 100) },
                humidity = rng.Next(0, 99999),
                pressure = rng.Next(0, 9999),
                visibility = rng.Next(0, 99999),
                wind = new Wind() { speed = rng.Next(-2, 20) },
                dewPoint = rng.Next(-10, 20)
            };

            return result;
        }
    }
}
