using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Flightreservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgencyId",
                table: "Packages",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HotelOffer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AgencyId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelOffer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelOffer_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelOffer_Hotels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourOffer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AgencyId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourOffer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourOffer_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourOffer_Tours_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelReservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfTravellers = table.Column<int>(type: "integer", nullable: false),
                    OfferId = table.Column<int>(type: "integer", nullable: false),
                    TouristId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelReservation_HotelOffer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "HotelOffer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelReservation_Tourists_TouristId",
                        column: x => x.TouristId,
                        principalTable: "Tourists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourReservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfTravellers = table.Column<int>(type: "integer", nullable: false),
                    OfferId = table.Column<int>(type: "integer", nullable: false),
                    TouristId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourReservation_TourOffer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "TourOffer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourReservation_Tourists_TouristId",
                        column: x => x.TouristId,
                        principalTable: "Tourists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReservation_Id",
                table: "FlightReservation",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelOffer_AgencyId",
                table: "HotelOffer",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelOffer_ProductId",
                table: "HotelOffer",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservation_OfferId",
                table: "HotelReservation",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservation_TouristId",
                table: "HotelReservation",
                column: "TouristId");

            migrationBuilder.CreateIndex(
                name: "IX_TourOffer_AgencyId",
                table: "TourOffer",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TourOffer_ProductId",
                table: "TourOffer",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TourReservation_OfferId",
                table: "TourReservation",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_TourReservation_TouristId",
                table: "TourReservation",
                column: "TouristId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages");

            migrationBuilder.DropTable(
                name: "HotelReservation");

            migrationBuilder.DropTable(
                name: "TourReservation");

            migrationBuilder.DropTable(
                name: "HotelOffer");

            migrationBuilder.DropTable(
                name: "TourOffer");

            migrationBuilder.DropIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_FlightReservation_Id",
                table: "FlightReservation");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "Packages");
        }
    }
}
