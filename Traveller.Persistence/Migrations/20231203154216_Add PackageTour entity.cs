using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPackageTourentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Packages_PackagesId",
                table: "PackageTour");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Tours_ToursId",
                table: "PackageTour");

            migrationBuilder.RenameColumn(
                name: "ToursId",
                table: "PackageTour",
                newName: "PackageId");

            migrationBuilder.RenameColumn(
                name: "PackagesId",
                table: "PackageTour",
                newName: "TourId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTour_ToursId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Packages_PackageId",
                table: "PackageTour");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Tours_TourId",
                table: "PackageTour");

            migrationBuilder.RenameColumn(
                name: "PackageId",
                table: "PackageTour",
                newName: "ToursId");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "PackageTour",
                newName: "PackagesId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTour_PackageId",
                table: "PackageTour",
                newName: "IX_PackageTour_ToursId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTour_Packages_PackagesId",
                table: "PackageTour",
                column: "PackagesId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTour_Tours_ToursId",
                table: "PackageTour",
                column: "ToursId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
