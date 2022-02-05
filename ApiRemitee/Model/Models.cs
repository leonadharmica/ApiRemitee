using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRemitee.Model
{
    public class MyContext : DbContext
    {
        public DbSet<MonedaDeCambio> MonedaDeCambios { get; set; }
        public DbSet<Fee> Fees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=JESSICA-PC;Initial Catalog=ApiRemitee;");
        }

    }

}
