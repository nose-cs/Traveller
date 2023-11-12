using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Packages_PackageId",
                table: "PackageTour");

            migrationBuilder.RenameColumn(
                name: "PackageId",
                table: "PackageTour",
                newName: "PackagesId");

            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Fax = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgencyUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    AgencyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgencyUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgencyUser_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgencyUser_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tourist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tourist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tourist_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgencyUser_AgencyId",
                table: "AgencyUser",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyUser_Id",
                table: "AgencyUser",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tourist_Id",
                table: "Tourist",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tourist_Nationality",
                table: "Tourist",
                column: "Nationality");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Id",
                table: "User",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTour_Packages_PackagesId",
                table: "PackageTour",
                column: "PackagesId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageTour_Packages_PackagesId",
                table: "PackageTour");

            migrationBuilder.DropTable(
                name: "AgencyUser");

            migrationBuilder.DropTable(
                name: "Tourist");

            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.RenameColumn(
                name: "PackagesId",
                table: "PackageTour",
                newName: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTour_Packages_PackageId",
                table: "PackageTour",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
