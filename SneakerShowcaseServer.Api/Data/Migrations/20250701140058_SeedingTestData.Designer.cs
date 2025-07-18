﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SneakerShowcaseServer.Api.Data;

#nullable disable

namespace SneakerShowcaseServer.Api.Data.Migrations
{
    [DbContext(typeof(SneakerShowcaseContext))]
    [Migration("20250701140058_SeedingTestData")]
    partial class SeedingTestData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.6");

            modelBuilder.Entity("SneakerShowcaseServer.Api.Entities.Sneaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MainImg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShoeImg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SneakerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sneakers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Nike",
                            Description = "Meet the leader of the pack. Walking on clouds above the noise...",
                            Link = "https://www.nike.com/t/air-max-1-essential-mens-shoes-2C5sX2/FZ5808-011",
                            MainImg = "/assets/1-m.webp",
                            ShoeImg = "/assets/nike-air-max-1-essential.webp",
                            SneakerName = "Nike Air Max 1 Essential"
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "Adidas",
                            Description = "Ultraboost running shoes made for high-performance comfort.",
                            Link = "https://www.adidas.com/us/ultraboost-light-shoes/ID9684.html",
                            MainImg = "/assets/2-m.webp",
                            ShoeImg = "/assets/adidas-ultraboost.webp",
                            SneakerName = "Adidas Ultraboost Light"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
