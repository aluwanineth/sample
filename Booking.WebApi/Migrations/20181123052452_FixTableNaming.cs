using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.WebApi.Migrations
{
    public partial class FixTableNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "To",
                table: "FlightSchedules",
                newName: "ToDestination");

            migrationBuilder.RenameColumn(
                name: "From",
                table: "FlightSchedules",
                newName: "FromDestination");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToDestination",
                table: "FlightSchedules",
                newName: "To");

            migrationBuilder.RenameColumn(
                name: "FromDestination",
                table: "FlightSchedules",
                newName: "From");
        }
    }
}
