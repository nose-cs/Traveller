using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Removeflightsreservationfrompackagereservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_FlightReservations_ArrivalFlightId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_FlightReservations_DepartureFlightId",
                table: "PackageReservations");

            migrationBuilder.DropIndex(
                name: "IX_PackageReservations_ArrivalFlightId",
                table: "PackageReservations");

            migrationBuilder.DropIndex(
                name: "IX_PackageReservations_DepartureFlightId",
                table: "PackageReservations");

            migrationBuilder.DropColumn(
                name: "ArrivalFlightId",
                table: "PackageReservations");

            migrationBuilder.DropColumn(
                name: "DepartureFlightId",
                table: "PackageReservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArrivalFlightId",
                table: "PackageReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartureFlightId",
                table: "PackageReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PackageReservations_ArrivalFlightId",
                table: "PackageReservations",
                column: "ArrivalFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageReservations_DepartureFlightId",
                table: "PackageReservations",
                column: "DepartureFlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_FlightReservations_ArrivalFlightId",
                table: "PackageReservations",
                column: "ArrivalFlightId",
                principalTable: "FlightReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_FlightReservations_DepartureFlightId",
                table: "PackageReservations",
                column: "DepartureFlightId",
                principalTable: "FlightReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
