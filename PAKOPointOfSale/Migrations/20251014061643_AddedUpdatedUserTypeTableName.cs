using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAKOPointOfSale.Migrations
{
    /// <inheritdoc />
    public partial class AddedUpdatedUserTypeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserType_user_type_id",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserType",
                table: "UserType");

            migrationBuilder.RenameTable(
                name: "UserType",
                newName: "UserTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_user_type_id",
                table: "Users",
                column: "user_type_id",
                principalTable: "UserTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_user_type_id",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes");

            migrationBuilder.RenameTable(
                name: "UserTypes",
                newName: "UserType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserType",
                table: "UserType",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserType_user_type_id",
                table: "Users",
                column: "user_type_id",
                principalTable: "UserType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
