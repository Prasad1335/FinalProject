using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class sumer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelAmenitiesLink_City_CityRefId",
                schema: "Master",
                table: "HotelAmenitiesLink");

            migrationBuilder.RenameColumn(
                name: "CityRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                newName: "AmenitiesRefId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelAmenitiesLink_CityRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                newName: "IX_HotelAmenitiesLink_AmenitiesRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelAmenitiesLink_Amenities_AmenitiesRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                column: "AmenitiesRefId",
                principalSchema: "Master",
                principalTable: "Amenities",
                principalColumn: "AmenitiesId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelAmenitiesLink_Amenities_AmenitiesRefId",
                schema: "Master",
                table: "HotelAmenitiesLink");

            migrationBuilder.RenameColumn(
                name: "AmenitiesRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                newName: "CityRefId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelAmenitiesLink_AmenitiesRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                newName: "IX_HotelAmenitiesLink_CityRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelAmenitiesLink_City_CityRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                column: "CityRefId",
                principalSchema: "Master",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
