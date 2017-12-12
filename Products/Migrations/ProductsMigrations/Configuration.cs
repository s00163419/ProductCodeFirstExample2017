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
        
        }
        
    }
}
