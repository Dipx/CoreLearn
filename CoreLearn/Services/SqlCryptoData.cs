using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLearn.Data;
using CoreLearn.Models;

namespace CoreLearn.Services
{
    public class SqlCryptoData : ICryptocurrency
    {
        private CoreLearnDbContext _context;

        public SqlCryptoData(CoreLearnDbContext context)
        {
            _context = context;
        }

        public Cryptocurrency Add(Cryptocurrency crypto)
        {
            _context.Cryptocurrencies.Add(crypto);
            _context.SaveChanges();

            return crypto;
        }

        public Cryptocurrency Get(int id)
        {
            return _context.Cryptocurrencies.FirstOrDefault(c => c.Id == id);
        }

        // IQueryable for larger db
        public IEnumerable<Cryptocurrency> GetAll()
        {
            return _context.Cryptocurrencies.OrderBy(c => c.Name);
        }
    }
}
