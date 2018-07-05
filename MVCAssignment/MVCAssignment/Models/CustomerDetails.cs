using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssignment.Models
{
    [Table("tblCustomerDetails")]
    //Model details
    public class CustomerDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    //database context
    public class CustomerDetailsDBContext : DbContext
    {
        public DbSet<CustomerDetails> CustomerDetailsDB { get; set; }
    }
}