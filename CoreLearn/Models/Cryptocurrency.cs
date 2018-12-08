using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CoreLearn.Models
{
    public class Cryptocurrency
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        [Display(Name="Crypto name")]
        public string Name { get; set; }


        public int PricePerUnit { get; set; }


        public int QuantityOwned { get; set; }

        [Required, MaxLength(5)]
        [Display(Name="Crypto ticker")]
        public string Ticker { get; set; }


        public CryptoType CryptoType { get; set; }
    }
}
