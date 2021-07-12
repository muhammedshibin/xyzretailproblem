using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Entities;

namespace XYZRetail.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(DataContextSeed.GetProducts());
            modelBuilder.Entity<Category>().HasData(DataContextSeed.GetCategories());

            modelBuilder.Entity<Product>().HasKey(i => i.Id);
            modelBuilder.Entity<Product>().Property(x => x.BasePrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BasketItem>().Property(x => x.ItemBasePrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BasketItem>().Property(x => x.ItemNetPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Basket>().Property(x => x.TotalPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Category>().Property(x => x.SalesTax).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Category>().Property(x => x.ImportTax).HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }


    }
}
