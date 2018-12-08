using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLearn.Models;
using CoreLearn.Services;
using CoreLearn.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreLearn.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private ICryptocurrency _cryptoData;

        public HomeController(ICryptocurrency cryptoData, IGreeter greeter)
        {
            _greeter = greeter;
            _cryptoData = cryptoData;
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Cryptocurrencies = _cryptoData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var model = _cryptoData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CryptoEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Cryptocurrency newCrypto = new Cryptocurrency();

            newCrypto.Name = model.Name;
            newCrypto.PricePerUnit = model.PricePerUnit;
            newCrypto.QuantityOwned = model.QuantityOwned;
            newCrypto.Ticker = model.Ticker;

            newCrypto = _cryptoData.Add(newCrypto);

            return RedirectToAction(nameof(Details), new { id = newCrypto.Id });
        }
    }
}