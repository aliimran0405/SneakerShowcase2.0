using System;

namespace SneakerShowcaseServer.Api.Entities;

// Determines the properties in the Sneaker table
public class Sneaker
{
    public int Id { get; set; }

    public required string ShoeImg { get; set; }

    public required string MainImg { get; set; }

    public required string BrandName { get; set; }

    public required string SneakerName { get; set; }

    public required string Description { get; set; }

    public required string Link { get; set; }
}
