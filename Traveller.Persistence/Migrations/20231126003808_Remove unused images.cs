using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Removeunusedimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Image_ImageId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Image_ImageId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_ImageId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Flights_ImageId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Flights");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Packages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Flights",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ImageId",
                table: "Packages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ImageId",
                table: "Flights",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Image_ImageId",
                table: "Flights",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Image_ImageId",
                table: "Packages",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
