using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjFashion.Core.AuthenEntities;
using ProjFashion.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Infrastructure.AppDbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductColorImage> ProductColorImages { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Product_Promotion> Product_Promotions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("your_connection_string_here");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<OrderDetail>().HasKey(oi => oi.Id);
            modelBuilder.Entity<Inventory>().HasKey(i => i.Id);
            modelBuilder.Entity<Brand>().HasKey(b => b.Id);
            modelBuilder.Entity<ProductColor>().HasKey(c => c.Id);
            modelBuilder.Entity<ProductColorImage>().HasKey(c => c.Id);
            modelBuilder.Entity<Product_Promotion>().HasKey(o => o.Id);
            modelBuilder.Entity<Promotion>().HasKey(o => o.Id);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.BrandId);

            modelBuilder.Entity<ProductColor>()
                .HasOne(p => p.Product)
                .WithMany(p => p.ProductColors)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<ProductColor>()
                .HasMany(p => p.ProductColorImages)
                .WithOne(f => f.ProductColor)
                .HasForeignKey(f => f.ProductColorId);

            modelBuilder.Entity<ProductColor>()
                .HasMany(p => p.Inventories)
                .WithOne(f => f.ProductColor)
                .HasForeignKey(p => p.ProductColorId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(oi => oi.ProductColor)
                .WithMany(p => p.OrderDetais)
                .HasForeignKey(oi => oi.ProductColorId);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.ProductColor)
                .WithMany(p => p.Inventories)
                .HasForeignKey(i => i.ProductColorId);
        }
    }
}
