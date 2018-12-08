using CoreLearn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLearn.Data
{
    public class CoreLearnDbContext : DbContext
    {
        public CoreLearnDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Cryptocurrency> Cryptocurrencies { get; set; }
    }
}
