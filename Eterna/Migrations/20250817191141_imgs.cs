using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna.Migrations
{
    /// <inheritdoc />
    public partial class imgs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioImg_Portfolios_PortfolioId",
                table: "PortfolioImg");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioImg",
                table: "PortfolioImg");

            migrationBuilder.RenameTable(
                name: "PortfolioImg",
                newName: "PortfolioImgs");

            migrationBuilder.RenameIndex(
                name: "IX_PortfolioImg_PortfolioId",
                table: "PortfolioImgs",
                newName: "IX_PortfolioImgs_PortfolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioImgs",
                table: "PortfolioImgs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioImgs_Portfolios_PortfolioId",
                table: "PortfolioImgs",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioImgs_Portfolios_PortfolioId",
                table: "PortfolioImgs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioImgs",
                table: "PortfolioImgs");

            migrationBuilder.RenameTable(
                name: "PortfolioImgs",
                newName: "PortfolioImg");

            migrationBuilder.RenameIndex(
                name: "IX_PortfolioImgs_PortfolioId",
                table: "PortfolioImg",
                newName: "IX_PortfolioImg_PortfolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioImg",
                table: "PortfolioImg",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioImg_Portfolios_PortfolioId",
                table: "PortfolioImg",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
