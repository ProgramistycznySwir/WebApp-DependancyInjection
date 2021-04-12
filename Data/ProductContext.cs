using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_DependancyInjection.Models;

namespace WebApp_DependancyInjection.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions options) : base(options) { }
    }
}
