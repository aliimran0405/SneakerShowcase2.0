using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SneakerShowcaseServer.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Link", "ShoeImg", "SneakerName" },
                values: new object[] { "Campus 00S running shoes made for high-performance comfort.", "https://www.adidas.com/us/campus-00s-shoes/GY6433.html", "/assets/campus-00s-shoe.webp", "Campus 00S" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Link", "ShoeImg", "SneakerName" },
                values: new object[] { "Ultraboost running shoes made for high-performance comfort.", "https://www.adidas.com/us/ultraboost-light-shoes/ID9684.html", "/assets/adidas-ultraboost.webp", "Adidas Ultraboost Light" });
        }
    }
}
