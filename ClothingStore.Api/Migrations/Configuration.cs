namespace ClothingStore.Api.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ClothingStore.Api.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ClothingStore.Api.Data.ClothingStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClothingStore.Api.Data.ClothingStoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //new List<Category>
            //{
            //    new Category { Name= "Shirts", Description="Formal shirts" },
            //    new Category { Name= "TShirts", Description="T shirts" },
            //    new Category { Name= "Denim", Description="Denim for male" },
            //    new Category { Name= "Kids", Description="Kids Items" },
            //    new Category { Name= "Male Gabardine", Description="Rough gabardine for men" },
            //    new Category { Name= "Male Trousers", Description="Comfortable pure cotton trousers" }
            //}.ForEach(cat => context.Categories.AddOrUpdate(cat));

            //context.SaveChanges();

            //new List<Product>
            //{
            //    new Product {Name="Male Business Shirts", Description="Shirts for Business", Price=7.99m, CategoryId=1 },
            //    new Product {Name="Male T Shirts", Description="TShirts for regular use ", Price=1.99m, CategoryId=2 },
            //    new Product {Name="Male Denim", Description="Stylish denims for men", Price=9.99m, CategoryId= 3},
            //    new Product {Name="Male Gabardin", Description="gabardine denim", Price=5.99m, CategoryId=5 },
            //    new Product {Name="Male Trousers", Description="Shirts for Business", Price=2.99m, CategoryId=6 },
            //    new Product {Name="Kids Shirts", Description="Shirts for Kids", Price=7.99m, CategoryId=4 },
            //    new Product {Name="Kids T Shirts", Description="TShirts for kids regular use ", Price=1.99m, CategoryId=4 },
            //    new Product {Name="Kids Denim", Description="denims for kids", Price=9.99m, CategoryId=4 },
            //    new Product {Name="Kids Gabardin", Description="gabardine denim", Price=5.99m, CategoryId=4 },
            //    new Product {Name="kids trousers", Description="kids", Price=2.99m, CategoryId=4 },
            //}.ForEach(p => context.Products.AddOrUpdate(p));

            //context.SaveChanges();

            //new List<Order>
            //{
            //    new Order() { Customer = "Danielle hasan", TotalCost = 68.45m,
            //    Lines = new List<OrderLine>
            //    {
            //    new OrderLine() { ProductId = 4, Count = 2},
            //    new OrderLine() { ProductId = 3, Count = 1},
            //    }},
            //    new Order() { Customer = "David Jones", TotalCost = 80m,
            //    Lines = new List<OrderLine>
            //    {
            //    new OrderLine() { ProductId = 5, Count = 1},
            //    new OrderLine() { ProductId = 6, Count = 3},
            //    new OrderLine() { ProductId = 1, Count = 3},
            //    }}
            //  }.ForEach(order => context.Orders.Add(order));
            //context.SaveChanges();

        }
    }
}
