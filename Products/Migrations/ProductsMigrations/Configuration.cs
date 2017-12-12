namespace Products.Migrations.ProductsMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Products.Models.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ProductsMigrations";
        }

        protected override void Seed(Products.Models.ProductDbContext context)
        {
            SeedCategoryProducts(context);
            SeedProductCategory(context);

        }
        private void SeedCategoryProducts(ProductDbContext context)
        {
            context.Categories.AddOrUpdate(c => c.CategoryName,
                new Category[]
                {
                    new Category
                    {
                         CategoryName = "Plumbing",
                          productsInCategory = new Product[]
                          {
                              new Product { Description = "stopper",
                                             FirstStockedOn = DateTime.Now - new TimeSpan(364,2,0,0),
                                               LastOrderDate = DateTime.Now - new TimeSpan(5,0,0),
                                                QuantityInStock = 200,
                                                 UnitPrice = 0.20f
                              }
                          }
                    }
                }
                );
        }
        private void SeedProductCategory(ProductDbContext context)
        {
            context.Products.AddOrUpdate(p => p.Description,
                new Product[] {
                    new Product { Description="9 inch Bolts",
                                  QuantityInStock = 200, UnitPrice = 0.50f,
                  FirstStockedOn = DateTime.Now - new TimeSpan(640,2,0,0),
                                  LastOrderDate = DateTime.Now - new TimeSpan(3,0,0),
                                  associatedCategory = new Category { CategoryName = "Building Supplies" },
                                        }
                                });

        }
    }
}
