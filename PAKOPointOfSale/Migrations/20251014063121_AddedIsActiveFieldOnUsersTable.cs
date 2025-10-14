using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAKOPointOfSale.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsActiveFieldOnUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_active",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "is_active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "is_active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                column: "is_active",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_active",
                table: "Users");
        }
    }
}
