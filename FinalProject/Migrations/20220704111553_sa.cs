using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class sa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_FromAirportRefId",
                schema: "Master",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_Airport_ToAirportRefId",
                schema: "Master",
                table: "Flight");

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_City_FromAirportRefId",
                schema: "Master",
                table: "Flight",
                column: "FromAirportRefId",
                principalSchema: "Master",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_City_ToAirportRefId",
                schema: "Master",
                table: "Flight",
                column: "ToAirportRefId",
                principalSchema: "Master",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flight_City_FromAirportRefId",
                schema: "Master",
                table: "Flight");

            migrationBuilder.DropForeignKey(
                name: "FK_Flight_City_ToAirportRefId",
                schema: "Master",
                table: "Flight");

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_FromAirportRefId",
                schema: "Master",
                table: "Flight",
                column: "FromAirportRefId",
                principalSchema: "Master",
                principalTable: "Airport",
                principalColumn: "AirportId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Flight_Airport_ToAirportRefId",
                schema: "Master",
                table: "Flight",
                column: "ToAirportRefId",
                principalSchema: "Master",
                principalTable: "Airport",
                principalColumn: "AirportId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
