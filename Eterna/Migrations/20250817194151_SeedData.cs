using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eterna.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Web Design" },
                    { 2, "Mobile App" },
                    { 3, "Branding" }
                });

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, 1, "A modern and responsive website design for a tech company.", "portfolio-1.webp", "Modern Website Design" },
                    { 2, 2, "A secure and user-friendly mobile banking application.", "portfolio-2.webp", "Mobile Banking App" },
                    { 3, 3, "Complete brand identity design for a startup company.", "portfolio-3.webp", "Brand Identity Design" }
                });

            migrationBuilder.InsertData(
                table: "PortfolioImgs",
                columns: new[] { "Id", "ImageUrl", "PortfolioId" },
                values: new object[,]
                {
                    { 1, "portfolio-1.webp", 1 },
                    { 2, "portfolio-4.webp", 1 },
                    { 3, "portfolio-7.webp", 1 },
                    { 4, "portfolio-2.webp", 2 },
                    { 5, "portfolio-5.webp", 2 },
                    { 6, "portfolio-3.webp", 3 },
                    { 7, "portfolio-6.webp", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortfolioImgs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PortfolioImgs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PortfolioImgs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PortfolioImgs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PortfolioImgs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PortfolioImgs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PortfolioImgs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
