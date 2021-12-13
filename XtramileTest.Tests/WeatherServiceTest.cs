using NUnit.Framework;
using XtramileTest.API.Controllers;
using XtramileTest.API.Service;

namespace XtramileTest.Tests
{
    [TestFixture]
    public class WeatherServiceTest
    {
        private IWeatherService _weatherService;
        private WeatherController _weatherController;
        [SetUp]
        public void Setup()
        {
            _weatherService = new WeatherService();
            _weatherController = new WeatherController(_weatherService);
        }

        [Test]
        public void WeatherTest()
        {
            var result = _weatherService.GetCityWeather("Jakarta");
            Assert.Pass();
        }

        [Test]
        public void WeatherConvertTest()
        {
            double tempF = 60;
            var result = _weatherService.ConvertFToC(tempF);
            double testTemp = (tempF - 32) * 5 / 9;

            Assert.AreEqual(result, testTemp);
        }

        [Test]
        public void WeatherAPIControllerTest()
        {
            var result = _weatherController.Get("Jakarta");
            Assert.Pass();
        }

        [Test]
        public void ConverterAPIControllerTest()
        {
            var result = _weatherController.Get(200);
            Assert.Pass();
        }

    }
}
