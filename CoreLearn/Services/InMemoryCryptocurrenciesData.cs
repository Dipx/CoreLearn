using CoreLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLearn.Services
{
    public class InMemoryCryptocurrenciesData : ICryptocurrency
    {
        private List<Cryptocurrency> _cryptocurrencies;

        public InMemoryCryptocurrenciesData()
        {
            _cryptocurrencies = new List<Cryptocurrency>
            {
                new Cryptocurrency { Id = 1, Name = "Bitcoin", PricePerUnit = 5000, QuantityOwned = 1},
                new Cryptocurrency { Id = 2, Name = "Ethereum", PricePerUnit = 400, QuantityOwned = 10},
                new Cryptocurrency { Id = 3, Name = "Neo", PricePerUnit = 8, QuantityOwned = 740}
            };
        }

        public IEnumerable<Cryptocurrency> GetAll()
        {
            return _cryptocurrencies;
        }
    }
}
