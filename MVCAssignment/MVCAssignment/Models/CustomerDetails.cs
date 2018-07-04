using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    //Model details
    public class CustomerDetails
    {
        [Key]
        public int CustomerDetailsId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    //database context
    public class CustomerDetailsDBContext : DbContext
    {
        public DbSet<CustomerDetails> CustomerDetailsDB { get; set; }
    }
}