using CoreLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLearn.Services
{
    public interface ICryptocurrency
    {
        IEnumerable<Cryptocurrency> GetAll();
    }
}
