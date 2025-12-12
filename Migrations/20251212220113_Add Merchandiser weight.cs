using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorGoldenZebra.Migrations
{
    /// <inheritdoc />
    public partial class AddMerchandiserweight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MerchandiserWeightClean",
                table: "OrderItems",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MerchandiserWeightDirty",
                table: "OrderItems",
                type: "numeric",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MerchandiserWeightClean",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "MerchandiserWeightDirty",
                table: "OrderItems");
        }
    }
}
