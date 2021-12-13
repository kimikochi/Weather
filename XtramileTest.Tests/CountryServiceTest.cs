using NUnit.Framework;
using XtramileTest.API.Controllers;
using XtramileTest.API.Service;

namespace XtramileTest.Tests
{
    [TestFixture]
    public class CountryServiceTest
    {
        private ICountryService _countryService;
        private CountryController _countryController; 
        [SetUp]
        public void Setup()
        {
            _countryService = new CountryService();
            _countryController = new CountryController(_countryService);
        }

        [Test]
        public void CountryTest()
        {
            var result = _countryService.GetCountry();
            Assert.Pass();
        }

        [Test]
        public void CityTest()
        {
            var result = _countryService.GetCities("Indonesia");
            Assert.IsFalse(result.Contains("DODOl"));
        }

        [Test]
        public void CityTest2()
        {
            var result = _countryService.GetCities("Indonesia");
            Assert.IsTrue(result.Contains("Jakarta"));
        }

        [Test]
        public void CityTestFailed()
        {
            var result = _countryService.GetCities("");
            Assert.Pass();
        }

        [Test]
        public void CountryAPIControllerTestFail()
        {
            var result = _countryController.Get();
            Assert.Fail("Hit API Failed");
        }

        [Test]
        public void CountryAPIControllerTest()
        {
            var result = _countryController.Get();
            Assert.Pass();
        }

        [Test]
        public void CityAPIControllerTest()
        {
            var result = _countryController.Get("Indonesia");
            Assert.Pass();
        }
    }
}