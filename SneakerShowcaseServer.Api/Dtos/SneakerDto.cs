namespace SneakerShowcaseServer.Api.Dtos;

public record class SneakerDto(
    int Id,
    string ShoeImg,
    string MainImg,
    string BrandName,
    string SneakerName,
    string Description,
    string Link
);

// public record class SneakerImages(
//     string ShoeImg,
//     string MainImg
// );
