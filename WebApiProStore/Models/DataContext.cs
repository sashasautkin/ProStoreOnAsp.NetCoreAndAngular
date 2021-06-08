using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProStore.Models
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingBag> ShoppingBags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasOne(p => p.users).WithMany(t => t.products).HasForeignKey(t => t.UserId);
            modelBuilder.Entity<ShoppingBag>().HasOne(p => p.users).WithMany(t => t.shoppingBags).HasForeignKey(t => t.UserId);
            modelBuilder.Entity<ShoppingBag>().HasOne(p => p.products).WithMany(t => t.shoppingBags).HasForeignKey(t => t.ProductId);


            modelBuilder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = "sadfasdfa",
                    UserId = "853a7c21-cd96-4f70-a2b6-26cc7d875177",
                    UserName = "sasha",
                    ProductName = "Car",
                    Price = 3000
                },
                new Product
                {
                    Id = "rrrrrrr",
                    UserId = "853a7c21-cd96-4f70-a2b6-26cc7d875177",
                    UserName = "sasha",
                    ProductName = "Laptop",
                    Price = 1000
                }
            );

            modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    Id = "853a7c21-cd96-4f70-a2b6-26cc7d877777",
                    UserName = "Narkoman",
                    PasswordHash = "AQAAAAEAACcQAAAAEIK69ry4C5Y7JCmXbtwK+mjyCmJdy65JqdDkxAtd+G26Aq8ajyUbPBe68DW5VSnO1w=="
                    
                },
                new User
                {
                    Id = "853a7c21-cd96-4f70-a2b6-26cc7d875111",
                    UserName = "Alkash",
                    PasswordHash = "AQAAAAEAACcQAAAAEIK69ry4C5Y7JCmXbtwK+mjyCmJdy65JqdDkxAtd+G26Aq8ajyUbPBe68DW5VSnO1w=="

                }
            );

            modelBuilder.Entity<ShoppingBag>().HasData
            (
                new ShoppingBag
                {
                    Id = "wqewqeweqeqweqeqweqweqweqweq",
                    UserId = "757b2c82-b69a-445f-b08a-7a4e2021892b",
                    ProductId = "sadfasdfa",
                    CustomerName = "sasha" , 
                    UserName = "vania",
                    ProductName = "Car",
                    Price = 3000
                },
                new ShoppingBag
                {
                    Id = "wewewrergfgdwtrwerwrewew",
                    UserId = "7125f2a3-55d7-4c79-9615-7c75db909649",
                    ProductId = "sadfasdfa",
                    CustomerName = "sasha",
                    UserName = "alla",
                    ProductName = "Car",
                    Price = 3000
                }
            );

        }
    }
}
