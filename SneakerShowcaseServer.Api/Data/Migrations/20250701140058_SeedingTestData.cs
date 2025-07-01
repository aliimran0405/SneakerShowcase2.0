using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SneakerShowcaseServer.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "Id", "BrandName", "Description", "Link", "MainImg", "ShoeImg", "SneakerName" },
                values: new object[,]
                {
                    { 1, "Nike", "Meet the leader of the pack. Walking on clouds above the noise...", "https://www.nike.com/t/air-max-1-essential-mens-shoes-2C5sX2/FZ5808-011", "/assets/1-m.webp", "/assets/nike-air-max-1-essential.webp", "Nike Air Max 1 Essential" },
                    { 2, "Adidas", "Ultraboost running shoes made for high-performance comfort.", "https://www.adidas.com/us/ultraboost-light-shoes/ID9684.html", "/assets/2-m.webp", "/assets/adidas-ultraboost.webp", "Adidas Ultraboost Light" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
