using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspcoremvc.Services.CurrencyService
{
    public class ModelBuilder
    {
        public List<Currency> GetRatesList()
        {
            string url = "https://bigpara.hurriyet.com.tr/doviz/";
            string mainXPath = "//div[@class='dovizBar mBot20']/a";
            string rateXPath = "./span[1]/span[1]";
            string buyXPath = "./span[2]/span[2]";
            string sellXPath = "./span[3]/span[2]";

            HtmlWeb htmlweb = new HtmlWeb();

            List<Currency> rates = new List<Currency>();

            var doc = htmlweb.Load(url);

            var nodes = doc.DocumentNode.SelectNodes(mainXPath);

            foreach (var item in nodes)
            {
                rates.Add(new Currency()
                {
                    Rate = item.SelectSingleNode(rateXPath).InnerText,
                    Buy = item.SelectSingleNode(buyXPath).InnerText,
                    Sell = item.SelectSingleNode(sellXPath).InnerText,
                });


            }

            return rates;

        }

    }
}
