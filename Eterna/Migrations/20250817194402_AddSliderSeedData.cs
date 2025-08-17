using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eterna.Migrations
{
    /// <inheritdoc />
    public partial class AddSliderSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ButtonText", "ButtonUrl", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Get Started", "#about", "We are team of talented designers making websites with Bootstrap", "hero-carousel-1.webp", "Welcome to <span>Eterna</span>" },
                    { 2, "Get Started", "#about", "Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus", "hero-carousel-2.webp", "At vero eos et <span>accusamus</span>" },
                    { 3, "Get Started", "#about", "Beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit", "hero-carousel-3.webp", "Temporibus autem <span>quibusdam</span>" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
