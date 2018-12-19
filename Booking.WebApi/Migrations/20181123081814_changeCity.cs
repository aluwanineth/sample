using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.WebApi.Migrations
{
    public partial class changeCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "city",
                table: "Airports",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Airports",
                newName: "city");
        }
    }
}
