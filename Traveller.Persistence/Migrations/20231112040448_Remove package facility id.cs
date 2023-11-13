using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Removepackagefacilityid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightOffer_Agencies_AgencyId",
                table: "FlightOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightOffer_Flights_ProductId",
                table: "FlightOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservation_FlightOffer_OfferId",
                table: "FlightReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservation_Tourists_TouristId",
                table: "FlightReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelOffer_Agencies_AgencyId",
                table: "HotelOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelOffer_Hotels_ProductId",
                table: "HotelOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservation_HotelOffer_OfferId",
                table: "HotelReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservation_Tourists_TouristId",
                table: "HotelReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_TourOffer_Agencies_AgencyId",
                table: "TourOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_TourOffer_Tours_ProductId",
                table: "TourOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservation_TourOffer_OfferId",
                table: "TourReservation");

            migrationBuilder.DropIndex(
                name: "IX_PackageFacility_Id",
                table: "PackageFacility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourOffer",
                table: "TourOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelReservation",
                table: "HotelReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelOffer",
                table: "HotelOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightReservation",
                table: "FlightReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightOffer",
                table: "FlightOffer");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PackageFacility");

            migrationBuilder.RenameTable(
                name: "TourOffer",
                newName: "TourOffers");

            migrationBuilder.RenameTable(
                name: "HotelReservation",
                newName: "HotelReservations");

            migrationBuilder.RenameTable(
                name: "HotelOffer",
                newName: "HotelOffers");

            migrationBuilder.RenameTable(
                name: "FlightReservation",
                newName: "FlightReservations");

            migrationBuilder.RenameTable(
                name: "FlightOffer",
                newName: "FlightOffers");

            migrationBuilder.RenameIndex(
                name: "IX_TourOffer_ProductId",
                table: "TourOffers",
                newName: "IX_TourOffers_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TourOffer_Id",
                table: "TourOffers",
                newName: "IX_TourOffers_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TourOffer_AgencyId",
                table: "TourOffers",
                newName: "IX_TourOffers_AgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservation_TouristId",
                table: "HotelReservations",
                newName: "IX_HotelReservations_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservation_OfferId",
                table: "HotelReservations",
                newName: "IX_HotelReservations_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservation_Id",
                table: "HotelReservations",
                newName: "IX_HotelReservations_Id");

            migrationBuilder.RenameIndex(
                name: "IX_HotelOffer_ProductId",
                table: "HotelOffers",
                newName: "IX_HotelOffers_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelOffer_Id",
                table: "HotelOffers",
                newName: "IX_HotelOffers_Id");

            migrationBuilder.RenameIndex(
                name: "IX_HotelOffer_AgencyId",
                table: "HotelOffers",
                newName: "IX_HotelOffers_AgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservation_TouristId",
                table: "FlightReservations",
                newName: "IX_FlightReservations_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservation_OfferId",
                table: "FlightReservations",
                newName: "IX_FlightReservations_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservation_Id",
                table: "FlightReservations",
                newName: "IX_FlightReservations_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FlightOffer_ProductId",
                table: "FlightOffers",
                newName: "IX_FlightOffers_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightOffer_Id",
                table: "FlightOffers",
                newName: "IX_FlightOffers_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FlightOffer_AgencyId",
                table: "FlightOffers",
                newName: "IX_FlightOffers_AgencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourOffers",
                table: "TourOffers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelReservations",
                table: "HotelReservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelOffers",
                table: "HotelOffers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightReservations",
                table: "FlightReservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightOffers",
                table: "FlightOffers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightOffers_Agencies_AgencyId",
                table: "FlightOffers",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightOffers_Flights_ProductId",
                table: "FlightOffers",
                column: "ProductId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservations_FlightOffers_OfferId",
                table: "FlightReservations",
                column: "OfferId",
                principalTable: "FlightOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservations_Tourists_TouristId",
                table: "FlightReservations",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelOffers_Agencies_AgencyId",
                table: "HotelOffers",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelOffers_Hotels_ProductId",
                table: "HotelOffers",
                column: "ProductId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_HotelOffers_OfferId",
                table: "HotelReservations",
                column: "OfferId",
                principalTable: "HotelOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservations_Tourists_TouristId",
                table: "HotelReservations",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourOffers_Agencies_AgencyId",
                table: "TourOffers",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourOffers_Tours_ProductId",
                table: "TourOffers",
                column: "ProductId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservation_TourOffers_OfferId",
                table: "TourReservation",
                column: "OfferId",
                principalTable: "TourOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightOffers_Agencies_AgencyId",
                table: "FlightOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightOffers_Flights_ProductId",
                table: "FlightOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservations_FlightOffers_OfferId",
                table: "FlightReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightReservations_Tourists_TouristId",
                table: "FlightReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelOffers_Agencies_AgencyId",
                table: "HotelOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelOffers_Hotels_ProductId",
                table: "HotelOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_HotelOffers_OfferId",
                table: "HotelReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservations_Tourists_TouristId",
                table: "HotelReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TourOffers_Agencies_AgencyId",
                table: "TourOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_TourOffers_Tours_ProductId",
                table: "TourOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReservation_TourOffers_OfferId",
                table: "TourReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourOffers",
                table: "TourOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelReservations",
                table: "HotelReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelOffers",
                table: "HotelOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightReservations",
                table: "FlightReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightOffers",
                table: "FlightOffers");

            migrationBuilder.RenameTable(
                name: "TourOffers",
                newName: "TourOffer");

            migrationBuilder.RenameTable(
                name: "HotelReservations",
                newName: "HotelReservation");

            migrationBuilder.RenameTable(
                name: "HotelOffers",
                newName: "HotelOffer");

            migrationBuilder.RenameTable(
                name: "FlightReservations",
                newName: "FlightReservation");

            migrationBuilder.RenameTable(
                name: "FlightOffers",
                newName: "FlightOffer");

            migrationBuilder.RenameIndex(
                name: "IX_TourOffers_ProductId",
                table: "TourOffer",
                newName: "IX_TourOffer_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TourOffers_Id",
                table: "TourOffer",
                newName: "IX_TourOffer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TourOffers_AgencyId",
                table: "TourOffer",
                newName: "IX_TourOffer_AgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservations_TouristId",
                table: "HotelReservation",
                newName: "IX_HotelReservation_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservations_OfferId",
                table: "HotelReservation",
                newName: "IX_HotelReservation_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReservations_Id",
                table: "HotelReservation",
                newName: "IX_HotelReservation_Id");

            migrationBuilder.RenameIndex(
                name: "IX_HotelOffers_ProductId",
                table: "HotelOffer",
                newName: "IX_HotelOffer_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelOffers_Id",
                table: "HotelOffer",
                newName: "IX_HotelOffer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_HotelOffers_AgencyId",
                table: "HotelOffer",
                newName: "IX_HotelOffer_AgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservations_TouristId",
                table: "FlightReservation",
                newName: "IX_FlightReservation_TouristId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservations_OfferId",
                table: "FlightReservation",
                newName: "IX_FlightReservation_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightReservations_Id",
                table: "FlightReservation",
                newName: "IX_FlightReservation_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FlightOffers_ProductId",
                table: "FlightOffer",
                newName: "IX_FlightOffer_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightOffers_Id",
                table: "FlightOffer",
                newName: "IX_FlightOffer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FlightOffers_AgencyId",
                table: "FlightOffer",
                newName: "IX_FlightOffer_AgencyId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PackageFacility",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourOffer",
                table: "TourOffer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelReservation",
                table: "HotelReservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelOffer",
                table: "HotelOffer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightReservation",
                table: "FlightReservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightOffer",
                table: "FlightOffer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PackageFacility_Id",
                table: "PackageFacility",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightOffer_Agencies_AgencyId",
                table: "FlightOffer",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightOffer_Flights_ProductId",
                table: "FlightOffer",
                column: "ProductId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservation_FlightOffer_OfferId",
                table: "FlightReservation",
                column: "OfferId",
                principalTable: "FlightOffer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightReservation_Tourists_TouristId",
                table: "FlightReservation",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelOffer_Agencies_AgencyId",
                table: "HotelOffer",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelOffer_Hotels_ProductId",
                table: "HotelOffer",
                column: "ProductId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservation_HotelOffer_OfferId",
                table: "HotelReservation",
                column: "OfferId",
                principalTable: "HotelOffer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservation_Tourists_TouristId",
                table: "HotelReservation",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourOffer_Agencies_AgencyId",
                table: "TourOffer",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourOffer_Tours_ProductId",
                table: "TourOffer",
                column: "ProductId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReservation_TourOffer_OfferId",
                table: "TourReservation",
                column: "OfferId",
                principalTable: "TourOffer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
