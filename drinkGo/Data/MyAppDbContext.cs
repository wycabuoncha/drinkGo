using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkGo.Models;
using Microsoft.EntityFrameworkCore;

namespace drinkGo.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}


