using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XtramileTest.Core.Models;

namespace XtramileTest.API.Service
{
    public interface ICountryService
    {
        List<string> GetCountry();
        List<string> GetCities(string country);
    }

    public class CountryService : ICountryService
    {
        public List<string> GetCities(string country)
        {
            var json = File.ReadAllText("countryList.json");

            var data = JsonConvert.DeserializeObject<Country>(json);

            var listOfCities = data.data.Where(x => x.country == country).Select(x => x.cities).FirstOrDefault();
            return listOfCities;
        }

        public List<string> GetCountry()
        {
            try
            {
                var json = File.ReadAllText("countryList.json");

                var data = JsonConvert.DeserializeObject<Country>(json);

                var listOfCountry = data.data.Select(x => x.country).ToList();
                return listOfCountry;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
