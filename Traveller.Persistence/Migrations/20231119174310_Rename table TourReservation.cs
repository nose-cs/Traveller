using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenametableTourReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservation_PackageOffers_OfferId",
                table: "PackageReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservation_Tourists_TouristId",
                table: "PackageReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservation_TourOffers_OfferId",
                table: "TourReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservation_Tourists_TouristId",
                table: "TourReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourReservation",
                table: "TourReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageReservation",
                table: "PackageReservation");

            migrationBuilder.RenameTable(
                name: "TourReservation",
                newName: "TourReservations");

            migrationBuilder.RenameTable(
                name: "PackageReservation",
                newName: "PackageReservations");

            migrationBuilder.RenameIndex(
                name: "IX_TourReservation_TouristId",
                table: "TourReservations",
                newName: "IX_TourReservations_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_TourReservation_OfferId",
                table: "TourReservations",
                newName: "IX_TourReservations_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_TourReservation_Id",
                table: "TourReservations",
                newName: "IX_TourReservations_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PackageReservation_TouristId",
                table: "PackageReservations",
                newName: "IX_PackageReservations_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageReservation_OfferId",
                table: "PackageReservations",
                newName: "IX_PackageReservations_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageReservation_Id",
                table: "PackageReservations",
                newName: "IX_PackageReservations_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourReservations",
                table: "TourReservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageReservations",
                table: "PackageReservations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_PackageOffers_OfferId",
                table: "PackageReservations",
                column: "OfferId",
                principalTable: "PackageOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_Tourists_TouristId",
                table: "PackageReservations",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservations_TourOffers_OfferId",
                table: "TourReservations",
                column: "OfferId",
                principalTable: "TourOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservations_Tourists_TouristId",
                table: "TourReservations",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_PackageOffers_OfferId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_Tourists_TouristId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservations_TourOffers_OfferId",
                table: "TourReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservations_Tourists_TouristId",
                table: "TourReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourReservations",
                table: "TourReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageReservations",
                table: "PackageReservations");

            migrationBuilder.RenameTable(
                name: "TourReservations",
                newName: "TourReservation");

            migrationBuilder.RenameTable(
                name: "PackageReservations",
                newName: "PackageReservation");

            migrationBuilder.RenameIndex(
                name: "IX_TourReservations_TouristId",
                table: "TourReservation",
                newName: "IX_TourReservation_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_TourReservations_OfferId",
                table: "TourReservation",
                newName: "IX_TourReservation_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_TourReservations_Id",
                table: "TourReservation",
                newName: "IX_TourReservation_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PackageReservations_TouristId",
                table: "PackageReservation",
                newName: "IX_PackageReservation_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageReservations_OfferId",
                table: "PackageReservation",
                newName: "IX_PackageReservation_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageReservations_Id",
                table: "PackageReservation",
                newName: "IX_PackageReservation_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourReservation",
                table: "TourReservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageReservation",
                table: "PackageReservation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservation_PackageOffers_OfferId",
                table: "PackageReservation",
                column: "OfferId",
                principalTable: "PackageOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservation_Tourists_TouristId",
                table: "PackageReservation",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservation_TourOffers_OfferId",
                table: "TourReservation",
                column: "OfferId",
                principalTable: "TourOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservation_Tourists_TouristId",
                table: "TourReservation",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
