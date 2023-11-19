using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addplacetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalPlace",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "DeparturePlace",
                table: "Tours");

            migrationBuilder.RenameColumn(
                name: "DepartureTime",
                table: "Tours",
                newName: "SourceTime");

            migrationBuilder.RenameColumn(
                name: "ArrivalTime",
                table: "Tours",
                newName: "DestinationTime");

            migrationBuilder.RenameColumn(
                name: "ArrivalDay",
                table: "Tours",
                newName: "SourcePlaceId");

            migrationBuilder.AddColumn<int>(
                name: "DestinationPlaceId",
                table: "Tours",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceDay",
                table: "Tours",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_DestinationPlaceId",
                table: "Tours",
                column: "DestinationPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_SourcePlaceId",
                table: "Tours",
                column: "SourcePlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Place_Id",
                table: "Place",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Place_DestinationPlaceId",
                table: "Tours",
                column: "DestinationPlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Place_SourcePlaceId",
                table: "Tours",
                column: "SourcePlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Place_DestinationPlaceId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Place_SourcePlaceId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropIndex(
                name: "IX_Tours_DestinationPlaceId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_SourcePlaceId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "DestinationPlaceId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "SourceDay",
                table: "Tours");

            migrationBuilder.RenameColumn(
                name: "SourceTime",
                table: "Tours",
                newName: "DepartureTime");

            migrationBuilder.RenameColumn(
                name: "SourcePlaceId",
                table: "Tours",
                newName: "ArrivalDay");

            migrationBuilder.RenameColumn(
                name: "DestinationTime",
                table: "Tours",
                newName: "ArrivalTime");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalPlace",
                table: "Tours",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeparturePlace",
                table: "Tours",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
