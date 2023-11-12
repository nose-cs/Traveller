using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Convertroletostring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgencyUser_Agency_AgencyId",
                table: "AgencyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_AgencyUser_User_Id",
                table: "AgencyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourist_User_Id",
                table: "Tourist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tourist",
                table: "Tourist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgencyUser",
                table: "AgencyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agency",
                table: "Agency");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Tourist",
                newName: "Tourists");

            migrationBuilder.RenameTable(
                name: "AgencyUser",
                newName: "AgencyUsers");

            migrationBuilder.RenameTable(
                name: "Agency",
                newName: "Agencies");

            migrationBuilder.RenameIndex(
                name: "IX_User_Id",
                table: "Users",
                newName: "IX_Users_Id");

            migrationBuilder.RenameIndex(
                name: "EmailIndex",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Tourist_Nationality",
                table: "Tourists",
                newName: "IX_Tourists_Nationality");

            migrationBuilder.RenameIndex(
                name: "IX_Tourist_Id",
                table: "Tourists",
                newName: "IX_Tourists_Id");

            migrationBuilder.RenameIndex(
                name: "IX_AgencyUser_Id",
                table: "AgencyUsers",
                newName: "IX_AgencyUsers_Id");

            migrationBuilder.RenameIndex(
                name: "IX_AgencyUser_AgencyId",
                table: "AgencyUsers",
                newName: "IX_AgencyUsers_AgencyId");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tourists",
                table: "Tourists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgencyUsers",
                table: "AgencyUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agencies",
                table: "Agencies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role",
                table: "Users",
                column: "Role");

            migrationBuilder.AddForeignKey(
                name: "FK_AgencyUsers_Agencies_AgencyId",
                table: "AgencyUsers",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgencyUsers_Users_Id",
                table: "AgencyUsers",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourists_Users_Id",
                table: "Tourists",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgencyUsers_Agencies_AgencyId",
                table: "AgencyUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AgencyUsers_Users_Id",
                table: "AgencyUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourists_Users_Id",
                table: "Tourists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Role",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tourists",
                table: "Tourists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgencyUsers",
                table: "AgencyUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agencies",
                table: "Agencies");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Tourists",
                newName: "Tourist");

            migrationBuilder.RenameTable(
                name: "AgencyUsers",
                newName: "AgencyUser");

            migrationBuilder.RenameTable(
                name: "Agencies",
                newName: "Agency");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Id",
                table: "User",
                newName: "IX_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "User",
                newName: "EmailIndex");

            migrationBuilder.RenameIndex(
                name: "IX_Tourists_Nationality",
                table: "Tourist",
                newName: "IX_Tourist_Nationality");

            migrationBuilder.RenameIndex(
                name: "IX_Tourists_Id",
                table: "Tourist",
                newName: "IX_Tourist_Id");

            migrationBuilder.RenameIndex(
                name: "IX_AgencyUsers_Id",
                table: "AgencyUser",
                newName: "IX_AgencyUser_Id");

            migrationBuilder.RenameIndex(
                name: "IX_AgencyUsers_AgencyId",
                table: "AgencyUser",
                newName: "IX_AgencyUser_AgencyId");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "User",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tourist",
                table: "Tourist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgencyUser",
                table: "AgencyUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agency",
                table: "Agency",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgencyUser_Agency_AgencyId",
                table: "AgencyUser",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgencyUser_User_Id",
                table: "AgencyUser",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourist_User_Id",
                table: "Tourist",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
