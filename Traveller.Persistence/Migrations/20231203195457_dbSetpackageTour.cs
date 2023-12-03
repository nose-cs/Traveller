using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dbSetpackageTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Packages_PackageId",
                table: "PackageTour");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Tours_TourId",
                table: "PackageTour");

            migrationBuilder.RenameTable(
                name: "PackageTour",
                newName: "PackageTours");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTour_PackageId",
                table: "PackageTours",
                newName: "IX_PackageTours_PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTours_Packages_PackageId",
                table: "PackageTours",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTours_Tours_TourId",
                table: "PackageTours",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageTours_Packages_PackageId",
                table: "PackageTours");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTours_Tours_TourId",
                table: "PackageTours");

            migrationBuilder.RenameTable(
                name: "PackageTours",
                newName: "PackageTour");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTours_PackageId",
                table: "PackageTour",
                newName: "IX_PackageTour_PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTour_Packages_PackageId",
                table: "PackageTour",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTour_Tours_TourId",
                table: "PackageTour",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
