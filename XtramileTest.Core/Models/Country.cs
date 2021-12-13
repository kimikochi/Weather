using System;
using System.Collections.Generic;
using System.Text;

namespace XtramileTest.Core.Models
{
    public class Country
    {
        public List<CountryAndCities> data { get; set; }
    }

    public class CountryAndCities
    {
        public string country { get; set; }
        public List<string> cities { get; set; }
    }
}
