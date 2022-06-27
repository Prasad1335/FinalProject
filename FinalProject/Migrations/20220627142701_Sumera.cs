using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class Sumera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Master");

            migrationBuilder.CreateTable(
                name: "Amenities",
                schema: "Master",
                columns: table => new
                {
                    AmenitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmenitiesName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AmenitiesDescription = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.AmenitiesId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "Master",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "varchar(900)", unicode: false, nullable: true),
                    CountryName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CountryShortName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "Master",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CountryRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryRefId",
                        column: x => x.CountryRefId,
                        principalSchema: "Master",
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Airline",
                schema: "Master",
                columns: table => new
                {
                    AirlineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AirlineShortName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AirlineLogo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AirlineAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CityRefId = table.Column<int>(type: "int", nullable: false),
                    AirlinePinCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AirlineTelephone1 = table.Column<long>(type: "bigint", nullable: false),
                    AirlineTelephone2 = table.Column<long>(type: "bigint", nullable: false),
                    AirlineEmail1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AirlineEmail2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline", x => x.AirlineId);
                    table.ForeignKey(
                        name: "FK_Airline_City_CityRefId",
                        column: x => x.CityRefId,
                        principalSchema: "Master",
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Airport",
                schema: "Master",
                columns: table => new
                {
                    AirportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirportCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AirportName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CityRefId = table.Column<int>(type: "int", nullable: false),
                    AirportPinCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AirportTelephone1 = table.Column<long>(type: "bigint", nullable: false),
                    AirportTelephone2 = table.Column<long>(type: "bigint", nullable: false),
                    AirportEmail1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AirportEmail2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.AirportId);
                    table.ForeignKey(
                        name: "FK_Airport_City_CityRefId",
                        column: x => x.CityRefId,
                        principalSchema: "Master",
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "Master",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerLastName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerDateOfBirth = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false),
                    CustomerAddress1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerAddress2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CityRefId = table.Column<int>(type: "int", nullable: false),
                    CustomerPinCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerTelephone = table.Column<int>(type: "int", nullable: false),
                    CustomerEmail = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_City_CityRefId",
                        column: x => x.CityRefId,
                        principalSchema: "Master",
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                schema: "Master",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    HotelStar = table.Column<int>(type: "int", nullable: false),
                    CityRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotel_City_CityRefId",
                        column: x => x.CityRefId,
                        principalSchema: "Master",
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "Master",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AirlineRefId = table.Column<int>(type: "int", nullable: false),
                    FromAirportRefId = table.Column<int>(type: "int", nullable: false),
                    ToAirportRefId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Flight_Airline_AirlineRefId",
                        column: x => x.AirlineRefId,
                        principalSchema: "Master",
                        principalTable: "Airline",
                        principalColumn: "AirlineId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flight_Airport_FromAirportRefId",
                        column: x => x.FromAirportRefId,
                        principalSchema: "Master",
                        principalTable: "Airport",
                        principalColumn: "AirportId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flight_Airport_ToAirportRefId",
                        column: x => x.ToAirportRefId,
                        principalSchema: "Master",
                        principalTable: "Airport",
                        principalColumn: "AirportId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HotelAmenitiesLink",
                schema: "Master",
                columns: table => new
                {
                    HotelAmenitiesLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelRefId = table.Column<int>(type: "int", nullable: false),
                    CityRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAmenitiesLink", x => x.HotelAmenitiesLinkId);
                    table.ForeignKey(
                        name: "FK_HotelAmenitiesLink_City_CityRefId",
                        column: x => x.CityRefId,
                        principalSchema: "Master",
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HotelAmenitiesLink_Hotel_HotelRefId",
                        column: x => x.HotelRefId,
                        principalSchema: "Master",
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airline_CityRefId",
                schema: "Master",
                table: "Airline",
                column: "CityRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Airport_AirportCode",
                schema: "Master",
                table: "Airport",
                column: "AirportCode",
                unique: true,
                filter: "[AirportCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Airport_CityRefId",
                schema: "Master",
                table: "Airport",
                column: "CityRefId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryRefId",
                schema: "Master",
                table: "City",
                column: "CountryRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CountryCode",
                schema: "Master",
                table: "Country",
                column: "CountryCode",
                unique: true,
                filter: "[CountryCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CityRefId",
                schema: "Master",
                table: "Customer",
                column: "CityRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_AirlineRefId",
                schema: "Master",
                table: "Flight",
                column: "AirlineRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_FlightCode",
                schema: "Master",
                table: "Flight",
                column: "FlightCode",
                unique: true,
                filter: "[FlightCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_FromAirportRefId",
                schema: "Master",
                table: "Flight",
                column: "FromAirportRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_ToAirportRefId",
                schema: "Master",
                table: "Flight",
                column: "ToAirportRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CityRefId",
                schema: "Master",
                table: "Hotel",
                column: "CityRefId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelAmenitiesLink_CityRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                column: "CityRefId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelAmenitiesLink_HotelRefId",
                schema: "Master",
                table: "HotelAmenitiesLink",
                column: "HotelRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "HotelAmenitiesLink",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Airline",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Airport",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Hotel",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "City",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "Master");
        }
    }
}
