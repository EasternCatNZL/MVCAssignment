using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssignment.Models
{
    [Table("tblProducts")]
    //Model details
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    //database context
    public class ProductsDBContext : DbContext
    {
        public DbSet<Product> ProductsDB { get; set; }
    }
}