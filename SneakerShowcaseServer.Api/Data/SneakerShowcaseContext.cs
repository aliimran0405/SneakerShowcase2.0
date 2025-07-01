using System;
using Microsoft.EntityFrameworkCore;
using SneakerShowcaseServer.Api.Entities;

namespace SneakerShowcaseServer.Api.Data;

public class SneakerShowcaseContext(DbContextOptions<SneakerShowcaseContext> options) : DbContext(options)
{
    //Sneaker is from Entities/Sneaker.cs
    // Creates the database/table instance
    public DbSet<Sneaker> Sneakers => Set<Sneaker>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Sneaker>().HasData(
            new Sneaker
            {
                Id = 1,
                ShoeImg = "/assets/nike-air-max-1-essential.webp",
                MainImg = "/assets/1-m.webp",
                BrandName = "Nike",
                SneakerName = "Nike Air Max 1 Essential",
                Description = "Meet the leader of the pack. Walking on clouds above the noise...",
                Link = "https://www.nike.com/t/air-max-1-essential-mens-shoes-2C5sX2/FZ5808-011"
            },
            new Sneaker
            {
                Id = 2,
                ShoeImg = "/assets/adidas-ultraboost.webp",
                MainImg = "/assets/2-m.webp",
                BrandName = "Adidas",
                SneakerName = "Adidas Ultraboost Light",
                Description = "Ultraboost running shoes made for high-performance comfort.",
                Link = "https://www.adidas.com/us/ultraboost-light-shoes/ID9684.html"
            }
        );
    }
}
