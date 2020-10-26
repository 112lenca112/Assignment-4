using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFExample
{
  
    public class NorthWindContext : DbContext
    {
        private readonly string _connectionString;

        public NorthWindContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NorthWindContext()
        {
        }

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<orders> Orders { get; set; }
        public DbSet<orderdetails>  Orderdetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");

            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("productid");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("productname");
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnName("categoryid");
            modelBuilder.Entity<Product>().Property(x => x.Quantityperunit).HasColumnName("quantityperunit");
            modelBuilder.Entity<Product>().Property(x => x.Unitprice).HasColumnName("unitprice");


            modelBuilder.Entity<Product>().ToTable("orders");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("orderid");


            modelBuilder.Entity<Product>().ToTable("orderdetails");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("orderid");
            modelBuilder.Entity<Product>().Property(x => x.ProductId).HasColumnName("productid");




        }
    }

    public class orders
    {
        internal object Category;
    }
}
