using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eterna.Migrations
{
    /// <inheritdoc />
    public partial class client : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

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
                table: "Sliders",
                columns: new[] { "Id", "ButtonText", "ButtonUrl", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Get Started", "#about", "We are team of talented designers making websites with Bootstrap", "hero-carousel-1.webp", "Welcome to <span>Eterna</span>" },
                    { 2, "Get Started", "#about", "Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus", "hero-carousel-2.webp", "At vero eos et <span>accusamus</span>" },
                    { 3, "Get Started", "#about", "Beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit", "hero-carousel-3.webp", "Temporibus autem <span>quibusdam</span>" }
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
    }
}
