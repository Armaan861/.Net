using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _6_Aug__2026.Migrations
{
    /// <inheritdoc />
    public partial class FixProductColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PId",
                table: "products",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "PId");
        }
    }
}
