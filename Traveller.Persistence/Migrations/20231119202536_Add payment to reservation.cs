using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addpaymenttoreservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "TourReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "PackageReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "HotelReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "FlightReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Total = table.Column<double>(type: "double precision", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TourReservations_PaymentId",
                table: "TourReservations",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackageReservations_PaymentId",
                table: "PackageReservations",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservations_PaymentId",
                table: "HotelReservations",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FlightReservations_PaymentId",
                table: "FlightReservations",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservations_Payment_PaymentId",
                table: "FlightReservations",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_Payment_PaymentId",
                table: "HotelReservations",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_Payment_PaymentId",
                table: "PackageReservations",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservations_Payment_PaymentId",
                table: "TourReservations",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservations_Payment_PaymentId",
                table: "FlightReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_Payment_PaymentId",
                table: "HotelReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_Payment_PaymentId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservations_Payment_PaymentId",
                table: "TourReservations");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_TourReservations_PaymentId",
                table: "TourReservations");

            migrationBuilder.DropIndex(
                name: "IX_PackageReservations_PaymentId",
                table: "PackageReservations");

            migrationBuilder.DropIndex(
                name: "IX_HotelReservations_PaymentId",
                table: "HotelReservations");

            migrationBuilder.DropIndex(
                name: "IX_FlightReservations_PaymentId",
                table: "FlightReservations");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "TourReservations");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "PackageReservations");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "HotelReservations");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "FlightReservations");
        }
    }
}
