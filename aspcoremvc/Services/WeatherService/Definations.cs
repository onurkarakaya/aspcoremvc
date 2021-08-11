using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspcoremvc.Services.WeatherService
{
    public class Definations
    {
        public bool Success { get; set; }
        public string City { get; set; }
        public List<Result> Result { get; set; }
    }

    public class Result
    {
        public string Date { get; set; }
        public string Day { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public float Degree { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
        public float Night { get; set; }
        public int Humidity { get; set; }
    }
}
