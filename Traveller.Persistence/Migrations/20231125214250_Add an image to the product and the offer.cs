using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addanimagetotheproductandtheoffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Duration",
                table: "Tours",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Tours",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "Capacity",
                table: "TourOffers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "TourOffers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Packages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "Capacity",
                table: "PackageOffers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "PackageOffers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Hotels",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "Capacity",
                table: "HotelOffers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "HotelOffers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Flights",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "Capacity",
                table: "FlightOffers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "FlightOffers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImagePath = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_ImageId",
                table: "Tours",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_TourOffers_ImageId",
                table: "TourOffers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ImageId",
                table: "Packages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffers_ImageId",
                table: "PackageOffers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_ImageId",
                table: "Hotels",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelOffers_ImageId",
                table: "HotelOffers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ImageId",
                table: "Flights",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightOffers_ImageId",
                table: "FlightOffers",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightOffers_Image_ImageId",
                table: "FlightOffers",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Image_ImageId",
                table: "Flights",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelOffers_Image_ImageId",
                table: "HotelOffers",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Image_ImageId",
                table: "Hotels",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffers_Image_ImageId",
                table: "PackageOffers",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TourOffers_Image_ImageId",
                table: "TourOffers",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Image_ImageId",
                table: "Tours",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightOffers_Image_ImageId",
                table: "FlightOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Image_ImageId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelOffers_Image_ImageId",
                table: "HotelOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Image_ImageId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffers_Image_ImageId",
                table: "PackageOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Image_ImageId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_TourOffers_Image_ImageId",
                table: "TourOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Image_ImageId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Tours_ImageId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_TourOffers_ImageId",
                table: "TourOffers");

            migrationBuilder.DropIndex(
                name: "IX_Packages_ImageId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_PackageOffers_ImageId",
                table: "PackageOffers");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_ImageId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_HotelOffers_ImageId",
                table: "HotelOffers");

            migrationBuilder.DropIndex(
                name: "IX_Flights_ImageId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_FlightOffers_ImageId",
                table: "FlightOffers");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "TourOffers");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "PackageOffers");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "HotelOffers");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "FlightOffers");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Tours",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "TourOffers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "PackageOffers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "HotelOffers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "FlightOffers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
