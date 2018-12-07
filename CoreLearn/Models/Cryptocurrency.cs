using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLearn.Models
{
    public class Cryptocurrency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PricePerUnit { get; set; }
        public int QuantityOwned { get; set; }
    }
}
