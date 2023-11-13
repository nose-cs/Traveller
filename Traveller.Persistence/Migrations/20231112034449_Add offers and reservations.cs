using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addoffersandreservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TourReservation_Id",
                table: "TourReservation",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TourOffer_Id",
                table: "TourOffer",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservation_Id",
                table: "HotelReservation",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelOffer_Id",
                table: "HotelOffer",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TourReservation_Id",
                table: "TourReservation");

            migrationBuilder.DropIndex(
                name: "IX_TourOffer_Id",
                table: "TourOffer");

            migrationBuilder.DropIndex(
                name: "IX_HotelReservation_Id",
                table: "HotelReservation");

            migrationBuilder.DropIndex(
                name: "IX_HotelOffer_Id",
                table: "HotelOffer");
        }
    }
}
