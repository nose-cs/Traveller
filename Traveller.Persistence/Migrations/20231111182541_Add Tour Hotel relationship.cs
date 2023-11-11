using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTourHotelrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Tours",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PackageFacility",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateTable(
                name: "ExtendedTourHotel",
                columns: table => new
                {
                    ExtendedTourId = table.Column<int>(type: "integer", nullable: false),
                    HotelsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtendedTourHotel", x => new { x.ExtendedTourId, x.HotelsId });
                    table.ForeignKey(
                        name: "FK_ExtendedTourHotel_Hotels_HotelsId",
                        column: x => x.HotelsId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtendedTourHotel_Tours_ExtendedTourId",
                        column: x => x.ExtendedTourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_Id",
                table: "Tours",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_Id",
                table: "Packages",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackageFacility_Id",
                table: "PackageFacility",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Id",
                table: "Hotels",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_Id",
                table: "Flights",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_Id",
                table: "Facilities",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExtendedTourHotel_HotelsId",
                table: "ExtendedTourHotel",
                column: "HotelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtendedTourHotel");

            migrationBuilder.DropIndex(
                name: "IX_Tours_Id",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Packages_Id",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_PackageFacility_Id",
                table: "PackageFacility");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_Id",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Flights_Id",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_Id",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Tours");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PackageFacility",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
