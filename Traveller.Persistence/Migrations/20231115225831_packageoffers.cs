using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class packageoffers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffer_Agencies_AgencyId",
                table: "PackageOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffer_Packages_ProductId",
                table: "PackageOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservation_PackageOffer_OfferId",
                table: "PackageReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageOffer",
                table: "PackageOffer");

            migrationBuilder.RenameTable(
                name: "PackageOffer",
                newName: "PackageOffers");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffer_ProductId",
                table: "PackageOffers",
                newName: "IX_PackageOffers_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffer_Id",
                table: "PackageOffers",
                newName: "IX_PackageOffers_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffer_AgencyId",
                table: "PackageOffers",
                newName: "IX_PackageOffers_AgencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageOffers",
                table: "PackageOffers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffers_Agencies_AgencyId",
                table: "PackageOffers",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffers_Packages_ProductId",
                table: "PackageOffers",
                column: "ProductId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservation_PackageOffers_OfferId",
                table: "PackageReservation",
                column: "OfferId",
                principalTable: "PackageOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffers_Agencies_AgencyId",
                table: "PackageOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffers_Packages_ProductId",
                table: "PackageOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservation_PackageOffers_OfferId",
                table: "PackageReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageOffers",
                table: "PackageOffers");

            migrationBuilder.RenameTable(
                name: "PackageOffers",
                newName: "PackageOffer");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffers_ProductId",
                table: "PackageOffer",
                newName: "IX_PackageOffer_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffers_Id",
                table: "PackageOffer",
                newName: "IX_PackageOffer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffers_AgencyId",
                table: "PackageOffer",
                newName: "IX_PackageOffer_AgencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageOffer",
                table: "PackageOffer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffer_Agencies_AgencyId",
                table: "PackageOffer",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffer_Packages_ProductId",
                table: "PackageOffer",
                column: "ProductId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservation_PackageOffer_OfferId",
                table: "PackageReservation",
                column: "OfferId",
                principalTable: "PackageOffer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
