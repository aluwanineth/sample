using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.WebApi.Migrations
{
    public partial class UpdatedAirport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Airportcountry",
                table: "Airports",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "AirportName",
                table: "Airports",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "city",
                table: "Airports",
                newName: "Airportcountry");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Airports",
                newName: "AirportName");
        }
    }
}
