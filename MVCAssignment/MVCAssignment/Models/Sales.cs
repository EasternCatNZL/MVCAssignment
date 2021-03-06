﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    //Model details
    public class Sales
    {
        [Key]
        public int SalesId { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int StoreID { get; set; }
        public DateTime DateSold { get; set; }
    }

    //database context
    public class SalesDBContext : DbContext
    {
        public DbSet<Sales> SalesDB { get; set; }
    }
}