using Alexanderi.ge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        public DbSet<LeatherProduct> LeatherProducts { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
