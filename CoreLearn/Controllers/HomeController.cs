using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLearn.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreLearn.Controllers
{
    public class HomeController : Controller
    {
        private ICryptocurrency _cryptoData;

        public HomeController(ICryptocurrency cryptoData)
        {
            _cryptoData = cryptoData;
        }

        public ViewResult Index()
        {
            var model = _cryptoData.GetAll().OrderBy(c => c.Name);

            return View(model);
        }
    }
}