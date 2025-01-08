using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjFashion.Core.AuthenEntities;
using ProjFashion.Core.Entities;
using ProjFashion.Core.Entities.Inventories;
using ProjFashion.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Infrastructure.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CategorySize> CategorySizes { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductVariantImage> ProductColorImages { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Product_Promotion> Product_Promotions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryProduct> InventoryProducts { get; set; }
        public DbSet<InventoryProduct_Detail> InventoryDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<Order>()
               .Property(x => x.Amount).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<OrderDetail>().HasKey(oi => oi.Id);
            modelBuilder.Entity<OrderDetail>()
                .Property(x => x.Discount).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<OrderDetail>()
                .Property(x => x.Price).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Inventory>().HasKey(i => i.Id);
            modelBuilder.Entity<InventoryProduct>().Property(x => x.SellingPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<InventoryProduct>().Property(x => x.InputPrice).HasColumnType("decimal(18,4)");

            modelBuilder.Entity<InventoryProduct_Detail>().HasKey(i => i.Id);
            modelBuilder.Entity<Brand>().HasKey(b => b.Id);
            modelBuilder.Entity<ProductVariant>().HasKey(c => c.Id);
            modelBuilder.Entity<ProductVariantImage>().HasKey(c => c.Id);
            modelBuilder.Entity<Product_Promotion>().HasKey(o => o.Id);
            modelBuilder.Entity<CategorySize>().HasKey(o => o.Id);
            modelBuilder.Entity<ProductColor>().HasKey(o => o.Id);
            modelBuilder.Entity<Promotion>().HasKey(o => o.Id);
            modelBuilder.Entity<Promotion>().Property(x => x.DiscountPercentage).HasColumnType("decimal(18,4)");

            //Reference
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.BrandId);

            modelBuilder.Entity<ProductVariant>()
                .HasOne(p => p.Product)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<ProductVariant>()
                .HasOne(p => p.ProductColor)
                .WithMany(f => f.ProductVariants)
                .HasForeignKey(f => f.ProductColourId);

            modelBuilder.Entity<ProductVariant>()
                .HasOne(p => p.CategorySize)
                .WithMany(f => f.ProductVariants)
                .HasForeignKey(f => f.CategorySizeId);

            modelBuilder.Entity<ProductVariantImage>()
                .HasOne(p => p.ProductVariant)
                .WithMany(f => f.ProductVariantImages)
                .HasForeignKey(f => f.ProductVariantId);

            modelBuilder.Entity<Category>()
                .HasMany(f => f.CategorySizes)
                .WithOne(f => f.Category)
                .HasForeignKey(f => f.CategoryId);


            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(oi => oi.OrderId);


            modelBuilder.Entity<InventoryProduct_Detail>()
                .HasOne(i => i.InventoryProduct)
                .WithMany(p => p.Details)
                .HasForeignKey(i => i.InventoryProductId);

            modelBuilder.Entity<InventoryProduct>()
                .HasOne(f => f.Inventory)
                .WithMany(p => p.InventoryProducts)
                .HasForeignKey(f => f.InventoryId);

            modelBuilder.Entity<InventoryProduct>()
             .HasOne(f => f.Product)
             .WithMany(p => p.InventoryProducts)
             .HasForeignKey(f => f.ProductId);
        }
    }
}
