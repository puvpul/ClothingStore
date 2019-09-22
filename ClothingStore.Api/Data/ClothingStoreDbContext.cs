using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ClothingStore.Api.Models;

namespace ClothingStore.Api.Data
{
    public class ClothingStoreDbContext : DbContext
    {
        public ClothingStoreDbContext() 
            : base("name=StoreDbConnection")
        {

        }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}