using System;
using Microsoft.AspNetCore.Http.HttpResults;
using SneakerShowcaseServer.Api.Data;
using SneakerShowcaseServer.Api.Dtos;

namespace SneakerShowcaseServer.Api.Endpoints;

public static class SneakersEndpoints
{
    // private static readonly List<SneakerDto> sneakers = [
    //     new(
    //         1,
    //         "/somewhereShoeImg",
    //         "/somewhereMainImg",
    //         "Nike",
    //         "Nike Air Max 1 Essential",
    //         "Some Description here for Air Max 1 Essentials",
    //         "A URI here"
    //     ),
    //     new(
    //         2,
    //         "/somewhereShoeImg",
    //         "/somewhereMainImg",
    //         "Adidas",
    //         "Campus 00S",
    //         "Some Description here for Campus 00S",
    //         "A URI here"
    //     )

    // ];

    public static RouteGroupBuilder MapSneakersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/sneakers").WithParameterValidation();

        group.MapGet("/", (SneakerShowcaseContext dbContext) =>
        {
            var SneakerEntities = dbContext.Sneakers.ToList();

            var SneakerDtos = SneakerEntities.Select(s => new SneakerDto(
                s.Id,
                s.ShoeImg,
                s.MainImg,
                s.BrandName,
                s.SneakerName,
                s.Description,
                s.Link
            )).ToList();

            return Results.Ok(SneakerDtos);
        });   

        group.MapGet("/{id}", async (int id, SneakerShowcaseContext dbContext) =>
        {
            var sneaker = await dbContext.Sneakers.FindAsync(id);

            if (sneaker is null)
                return Results.NotFound();

            var sneakerDto = new SneakerDto(
                sneaker.Id,
                sneaker.ShoeImg,
                sneaker.MainImg,
                sneaker.BrandName,
                sneaker.SneakerName,
                sneaker.Description,
                sneaker.Link
            );

            return Results.Ok(sneakerDto);
        });


        return group;
    }
}
