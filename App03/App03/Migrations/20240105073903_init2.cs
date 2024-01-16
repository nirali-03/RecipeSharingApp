using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App03.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_register",
                table: "register");

            migrationBuilder.RenameTable(
                name: "register",
                newName: "Register");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Register",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Register",
                table: "Register",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Register",
                table: "Register");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Register");

            migrationBuilder.RenameTable(
                name: "Register",
                newName: "register");

            migrationBuilder.AddPrimaryKey(
                name: "PK_register",
                table: "register",
                column: "UserId");
        }
    }
}
