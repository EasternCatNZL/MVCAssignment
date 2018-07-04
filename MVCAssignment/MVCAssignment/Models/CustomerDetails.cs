using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    //Model details
    public class CustomerDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    //database context
    public class CustomerDetailsDBContext : DbContext
    {
        public DbSet<CustomerDetails> CustomerDetailsDB { get; set; }
    }
}