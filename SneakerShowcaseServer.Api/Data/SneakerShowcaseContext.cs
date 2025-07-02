using System;
using Microsoft.EntityFrameworkCore;
using SneakerShowcaseServer.Api.Entities;
using SneakerShowcaseServer.Api.UtilsDir;

namespace SneakerShowcaseServer.Api.Data;

public class SneakerShowcaseContext(DbContextOptions<SneakerShowcaseContext> options) : DbContext(options)
{
    //Sneaker is from Entities/Sneaker.cs
    // Creates the database/table instance
    public DbSet<Sneaker> Sneakers => Set<Sneaker>();

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);

    //     var SneakerDataList = Utils.ReadJSON();

    //     modelBuilder.Entity<Sneaker>().HasData(SneakerDataList.ToArray());
    // }
}
