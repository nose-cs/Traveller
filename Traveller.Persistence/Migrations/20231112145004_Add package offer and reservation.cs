using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addpackageofferandreservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "Packages");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Packages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PackageOffer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AgencyId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageOffer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageOffer_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageOffer_Packages_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageReservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfTravellers = table.Column<int>(type: "integer", nullable: false),
                    OfferId = table.Column<int>(type: "integer", nullable: false),
                    TouristId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageReservation_PackageOffer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "PackageOffer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageReservation_Tourists_TouristId",
                        column: x => x.TouristId,
                        principalTable: "Tourists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffer_AgencyId",
                table: "PackageOffer",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffer_Id",
                table: "PackageOffer",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackageOffer_ProductId",
                table: "PackageOffer",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageReservation_Id",
                table: "PackageReservation",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackageReservation_OfferId",
                table: "PackageReservation",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageReservation_TouristId",
                table: "PackageReservation",
                column: "TouristId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageReservation");

            migrationBuilder.DropTable(
                name: "PackageOffer");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Packages");

            migrationBuilder.AddColumn<int>(
                name: "AgencyId",
                table: "Packages",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages",
                column: "AgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }
    }
}
