using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store1.Migrations
{
    /// <inheritdoc />
    public partial class Dates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "OrderItem",
                newName: "Dates");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dates",
                table: "OrderItem",
                newName: "Date");
        }
    }
}
