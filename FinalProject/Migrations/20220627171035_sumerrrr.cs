using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class sumerrrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerAdult",
                schema: "Transaction",
                table: "FlightSchedule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PricePerAdult",
                schema: "Transaction",
                table: "FlightSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
