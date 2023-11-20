using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenamePaymenttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Payment_Users_UserId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservations_Payment_PaymentId",
                table: "TourReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_UserId",
                table: "Payments",
                newName: "IX_Payments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_Id",
                table: "Payments",
                newName: "IX_Payments_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservations_Payments_PaymentId",
                table: "FlightReservations",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_Payments_PaymentId",
                table: "HotelReservations",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_Payments_PaymentId",
                table: "PackageReservations",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservations_Payments_PaymentId",
                table: "TourReservations",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservations_Payments_PaymentId",
                table: "FlightReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_Payments_PaymentId",
                table: "HotelReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_Payments_PaymentId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservations_Payments_PaymentId",
                table: "TourReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserId",
                table: "Payment",
                newName: "IX_Payment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_Id",
                table: "Payment",
                newName: "IX_Payment_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

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
                name: "FK_Payment_Users_UserId",
                table: "Payment",
                column: "UserId",
                principalTable: "Users",
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
    }
}
