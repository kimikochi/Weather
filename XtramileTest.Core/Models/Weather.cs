using System;
using System.Collections.Generic;
using System.Text;

namespace XtramileTest.Core.Models
{
    public class Weather
    {
        public string name { get; set; }
        public Location coord { get; set; }
        public string date { get; set; }
        public double temperatureC { get; set; }
        public double temperatureF { get; set; }
        public string skyCondition { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public int dewPoint { get; set; }
        public int humidity { get; set; }              
        public double pressure { get; set; }
    }

    public class Location
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }
}
