using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspcoremvc.Services.CurrencyService;
using System.Globalization;

namespace aspcoremvc.Controllers
{
    public class CurrencyController : Controller
    {
        
        public IActionResult Index()
        {
            ModelBuilder mb = new ModelBuilder();

            var model = mb.GetRatesList();

            return View(model);
        }
    }
}
