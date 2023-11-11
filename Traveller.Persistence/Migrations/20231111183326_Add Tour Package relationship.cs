using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTourPackagerelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Packages_PackageId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_PackageId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Tours");

            migrationBuilder.CreateTable(
                name: "PackageTour",
                columns: table => new
                {
                    PackageId = table.Column<int>(type: "integer", nullable: false),
                    ToursId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageTour", x => new { x.PackageId, x.ToursId });
                    table.ForeignKey(
                        name: "FK_PackageTour_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageTour_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageTour_ToursId",
                table: "PackageTour",
                column: "ToursId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageTour");

            migrationBuilder.AddColumn<int>(
                name: "PackageId",
                table: "Tours",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tours_PackageId",
                table: "Tours",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Packages_PackageId",
                table: "Tours",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id");
        }
    }
}
