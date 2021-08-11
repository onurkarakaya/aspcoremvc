using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;

namespace aspcoremvc.Services.WeatherService
{
    public class ModelBuilder
    {
        WebClient webClient;
        private string _cityName;

        public ModelBuilder(string cityName)
        {
            _cityName = cityName;
        }

        public Definations Build()
        {
            var model = JsonConvert.DeserializeObject<Definations>(GetJsonData());

            return model;
            
        }

        public List<Result> BuildList()
        {
            List<Result> list = new List<Result>();

            var model = Build();

            foreach (var item in model.Result)
            {
                list.Add(new Result
                {
                    Date = item.Date,
                    Day=item.Day,
                    Icon = item.Icon,
                    Description = item.Description,
                    Status = item.Status,
                    Degree = item.Degree,
                    Min = item.Min,
                    Max = item.Max,
                    Night = item.Night,
                    Humidity = item.Humidity,
                });
            }


            return list;

        }

        public string GetJsonData()
        {
            string downloadedJson;
            string url = "https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=" + _cityName;

            webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            webClient.Headers.Add("authorization", "apikey 6KUTEaHaf5P2EpYuoBdPIO:11qPMc39SoRk74Zb4l8mqE");
            webClient.Headers.Add("content-type", "application/json");

            downloadedJson = webClient.DownloadString(url);


            return downloadedJson;
        }
    }
}
