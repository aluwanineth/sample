using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.WebApi.Migrations
{
    public partial class ChangeDatatyeCapacity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Flights",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Flights",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
