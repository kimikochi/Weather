using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XtramileTest.API.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace XtramileTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public List<string> Get()
        {
            var result = _countryService.GetCountry();
            return result;
        }

        [HttpGet("cities/{id}")]
        public List<string> Get(string id)
        {
            var result = _countryService.GetCities(id);
            return result;
        }
    }
}
