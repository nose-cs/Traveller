using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mergepackageandpackageoffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_PackageOffers_OfferId",
                table: "PackageReservations");

            migrationBuilder.DropTable(
                name: "PackageOffers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Packages",
                newName: "Title");

            migrationBuilder.AlterColumn<long>(
                name: "Duration",
                table: "Packages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "AgencyId",
                table: "Packages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Capacity",
                table: "Packages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Packages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Packages",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Packages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Packages",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Packages",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ImageId",
                table: "Packages",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_Packages_OfferId",
                table: "PackageReservations",
                column: "OfferId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages",
                column: "AgencyId",
                principalTable: "Agencies",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservations_Packages_OfferId",
                table: "PackageReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Image_ImageId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_ImageId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Packages");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Packages",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Packages",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "PackageOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AgencyId = table.Column<int>(type: "integer", nullable: false),
                    ImageId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageOffers_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageOffers_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageOffers_Packages_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffers_AgencyId",
                table: "PackageOffers",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffers_Id",
                table: "PackageOffers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffers_ImageId",
                table: "PackageOffers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffers_ProductId",
                table: "PackageOffers",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservations_PackageOffers_OfferId",
                table: "PackageReservations",
                column: "OfferId",
                principalTable: "PackageOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
