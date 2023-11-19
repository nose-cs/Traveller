using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PopulateHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffer_Agencies_AgencyId",
                table: "PackageOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffer_Packages_ProductId",
                table: "PackageOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservation_PackageOffer_OfferId",
                table: "PackageReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageOffer",
                table: "PackageOffer");

            migrationBuilder.RenameTable(
                name: "PackageOffer",
                newName: "PackageOffers");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffer_ProductId",
                table: "PackageOffers",
                newName: "IX_PackageOffers_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffer_Id",
                table: "PackageOffers",
                newName: "IX_PackageOffers_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffer_AgencyId",
                table: "PackageOffers",
                newName: "IX_PackageOffers_AgencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageOffers",
                table: "PackageOffers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Category", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main Street, New York, NY", 4, "The Grand Hotel" },
                    { 2, "456 Broadway, Los Angeles, CA", 3, "The Ritz Carlton" },
                    { 3, "789 Fifth Avenue, New York, NY", 5, "The Plaza Hotel" },
                    { 4, "321 Park Avenue, New York, NY", 3, "The Waldorf Astoria" },
                    { 5, "654 Broadway, New York, NY", 2, "The Four Seasons" },
                    { 6, "987 Wilshire Boulevard, Los Angeles, CA", 4, "The Beverly Wilshire" },
                    { 7, "111 Del Mar Drive, Delaire, DE", 5, "The Ritz-Carlton, Delaire" },
                    { 8, "222 Cancun Drive, Cancun, MX", 4, "The Ritz-Carlton, Cancun" },
                    { 9, "333 Silom Road, Bangkok, TH", 5, "The Ritz-Carlton, Bangkok" },
                    { 10, "444 St. Thomas Drive, St. Thomas, VI", 1, "The Ritz-Carlton, St. Thomas" },
                    { 11, "555 Champs-Elysées, Paris, FR", 5, "The Ritz-Carlton, Paris" },
                    { 12, "666 Via Veneto, Rome, IT", 4, "The Ritz-Carlton, Rome" },
                    { 13, "777 Rue du Rhône, Geneva, CH", 5, "The Ritz-Carlton, Geneva" },
                    { 14, "888 Union Square, San Francisco, CA", 5, "The Ritz-Carlton, San Francisco" },
                    { 15, "999 Commonwealth Avenue, Boston, MA", 3, "The Ritz-Carlton, Boston" },
                    { 16, "1111 Horton Plaza, San Diego, CA", 4, "The Ritz-Carlton, San Diego" },
                    { 17, "2222 Michigan Avenue, Chicago, IL", 3, "The Ritz-Carlton, Chicago" },
                    { 18, "3333 Collins Avenue, Miami, FL", 1, "The Ritz-Carlton, Miami" },
                    { 19, "4444 Kalakaua Avenue, Honolulu, HI", 2, "The Ritz-Carlton, Honolulu" },
                    { 20, "5555 International Drive, Orlando, FL", 3, "The Ritz-Carlton, Orlando" },
                    { 21, "6666 Las Vegas Boulevard South, Las Vegas, NV", 4, "The Ritz-Carlton, Las Vegas" },
                    { 22, "7777 Commerce Street, San Antonio, TX", 5, "The Ritz-Carlton, San Antonio" },
                    { 23, "8888 Market Center Drive, Dallas, TX", 2, "The Ritz-Carlton, Dallas" },
                    { 24, "9999 Peachtree Street, Atlanta, GA", 4, "The Ritz-Carlton, Atlanta" },
                    { 25, "11111 University Street, Seattle, WA", 3, "The Ritz-Carlton, Seattle" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffers_Agencies_AgencyId",
                table: "PackageOffers",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffers_Packages_ProductId",
                table: "PackageOffers",
                column: "ProductId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservation_PackageOffers_OfferId",
                table: "PackageReservation",
                column: "OfferId",
                principalTable: "PackageOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffers_Agencies_AgencyId",
                table: "PackageOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageOffers_Packages_ProductId",
                table: "PackageOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageReservation_PackageOffers_OfferId",
                table: "PackageReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageOffers",
                table: "PackageOffers");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.RenameTable(
                name: "PackageOffers",
                newName: "PackageOffer");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffers_ProductId",
                table: "PackageOffer",
                newName: "IX_PackageOffer_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffers_Id",
                table: "PackageOffer",
                newName: "IX_PackageOffer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PackageOffers_AgencyId",
                table: "PackageOffer",
                newName: "IX_PackageOffer_AgencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageOffer",
                table: "PackageOffer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffer_Agencies_AgencyId",
                table: "PackageOffer",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageOffer_Packages_ProductId",
                table: "PackageOffer",
                column: "ProductId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageReservation_PackageOffer_OfferId",
                table: "PackageReservation",
                column: "OfferId",
                principalTable: "PackageOffer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
