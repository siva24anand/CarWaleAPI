using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
    public class CarviewContext: DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }

        private readonly string _dbConnectionstring = @"Server=MININT-454LNE9;Database=carview;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnectionstring);
        }
    }
}
