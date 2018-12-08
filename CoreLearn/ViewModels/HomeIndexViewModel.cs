using CoreLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLearn.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Cryptocurrency> Cryptocurrencies { get; set; }
        public string CurrentMessage { get; set; }
    }
}
