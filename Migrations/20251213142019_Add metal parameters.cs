using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorGoldenZebra.Migrations
{
    /// <inheritdoc />
    public partial class Addmetalparameters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChemicalName",
                table: "MetalTypes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "MetalTypes",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChemicalName", "Color" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChemicalName", "Color" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChemicalName", "Color" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChemicalName", "Color" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChemicalName",
                table: "MetalTypes");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "MetalTypes");
        }
    }
}
