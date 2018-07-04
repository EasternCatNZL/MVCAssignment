using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    //Model details
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    //database context
    public class ProductsDBContext : DbContext
    {
        public DbSet<Product> ProductsDB { get; set; }
    }
}