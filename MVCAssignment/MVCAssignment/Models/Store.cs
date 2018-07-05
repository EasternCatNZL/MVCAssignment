﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssignment.Models
{
    [Table("tblStores")]
    //Model details
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    //database context
    public class StoresDBContext : DbContext
    {
        public DbSet<Store> StoresDB { get; set; }
    }
}