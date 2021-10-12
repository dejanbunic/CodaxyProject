using CodaxyProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodaxyProject.Config
{
    public class CodaxyDBContext: DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=codaxyDB;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Cart>().HasData(
                    new Cart
                    {
                        Id = 1,
                        Status = Enumerations.StatusEnum.Draft,
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Dejan Bunic"
                    },
                    new Cart 
                    {
                        Id = 2,
                        Status = Enumerations.StatusEnum.Submitted,
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Pero Peric"
                    },
                    new Cart
                    {
                        Id = 3,
                        Status = Enumerations.StatusEnum.Cancelled,
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Pero Budak"
                    }
                );
            modelBuilder.Entity<CartItem>().HasData( 
                    new CartItem 
                    {
                        Id = 1,
                        CartId = 1,
                        Name = "kukuruz",
                        Description = "hibridni kukuruz",
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Dejan Bunic"
                    },
                    new CartItem
                    {
                        Id = 2,
                        CartId = 1,
                        Name = "krompir",
                        Description = "crveni",
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Dejan Bunic"
                    },
                    new CartItem
                    {
                        Id = 3,
                        CartId = 2,
                        Name = "krompir",
                        Description = "crveni",
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Pero Peric"
                    },
                    new CartItem
                    {
                        Id = 4,
                        CartId = 2,
                        Name = "cips",
                        Description = "ljuta paprika",
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Pero Peric"
                    },
                    new CartItem
                    {
                        Id = 5,
                        CartId = 3,
                        Name = "sjemenke bundeve",
                        Description = "slane przene",
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Pero Budak"
                    },
                    new CartItem
                    {
                        Id = 6,
                        CartId = 3,
                        Name = "oslic",
                        Description = "zaledjeni fileti",
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Pero Budak"
                    },
                    new CartItem
                    {
                        Id = 7,
                        CartId = 3,
                        Name = "cokolada",
                        Description = "sa ljesnjakom",
                        TimeCreated = DateTime.Now,
                        TimeUpdated = DateTime.Now,
                        CreatedBy = "Pero Budak"
                    }

            );
        }
        
    }
}
