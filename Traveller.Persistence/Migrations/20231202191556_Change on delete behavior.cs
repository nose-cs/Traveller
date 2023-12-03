using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Changeondeletebehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservations_FlightOffers_OfferId",
                table: "FlightReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_HotelOffers_OfferId",
                table: "HotelReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_Packages_OfferId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservations_TourOffers_OfferId",
                table: "TourReservations");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservations_FlightOffers_OfferId",
                table: "FlightReservations",
                column: "OfferId",
                principalTable: "FlightOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_HotelOffers_OfferId",
                table: "HotelReservations",
                column: "OfferId",
                principalTable: "HotelOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_Packages_OfferId",
                table: "PackageReservations",
                column: "OfferId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservations_TourOffers_OfferId",
                table: "TourReservations",
                column: "OfferId",
                principalTable: "TourOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservations_FlightOffers_OfferId",
                table: "FlightReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_HotelOffers_OfferId",
                table: "HotelReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_Packages_OfferId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservations_TourOffers_OfferId",
                table: "TourReservations");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservations_FlightOffers_OfferId",
                table: "FlightReservations",
                column: "OfferId",
                principalTable: "FlightOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_HotelOffers_OfferId",
                table: "HotelReservations",
                column: "OfferId",
                principalTable: "HotelOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_Packages_OfferId",
                table: "PackageReservations",
                column: "OfferId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservations_TourOffers_OfferId",
                table: "TourReservations",
                column: "OfferId",
                principalTable: "TourOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
