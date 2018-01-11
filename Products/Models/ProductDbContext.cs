﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        //=================================================

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        

    }
}