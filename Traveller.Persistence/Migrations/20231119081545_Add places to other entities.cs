using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addplacestootherentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Agencies");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "Tourists",
                newName: "Country");

            migrationBuilder.RenameIndex(
                name: "IX_Tourists_Nationality",
                table: "Tourists",
                newName: "IX_Tourists_Country");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Hotels",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Flights",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "Flights",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Agencies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Place_City",
                table: "Place",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_Place_Country",
                table: "Place",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_AddressId",
                table: "Hotels",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DestinationId",
                table: "Flights",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_SourceId",
                table: "Flights",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Agencies_AddressId",
                table: "Agencies",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencies_Place_AddressId",
                table: "Agencies",
                column: "AddressId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Place_DestinationId",
                table: "Flights",
                column: "DestinationId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Place_SourceId",
                table: "Flights",
                column: "SourceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Place_AddressId",
                table: "Hotels",
                column: "AddressId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencies_Place_AddressId",
                table: "Agencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Place_DestinationId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Place_SourceId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Place_AddressId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Place_City",
                table: "Place");

            migrationBuilder.DropIndex(
                name: "IX_Place_Country",
                table: "Place");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_AddressId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Flights_DestinationId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_SourceId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Agencies_AddressId",
                table: "Agencies");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Agencies");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Tourists",
                newName: "Nationality");

            migrationBuilder.RenameIndex(
                name: "IX_Tourists_Country",
                table: "Tourists",
                newName: "IX_Tourists_Nationality");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Hotels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Flights",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Flights",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Agencies",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
