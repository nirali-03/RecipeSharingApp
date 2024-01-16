using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App03.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipeName",
                table: "Post",
                newName: "recipeName");

            migrationBuilder.RenameColumn(
                name: "RecipeImage",
                table: "Post",
                newName: "recipeImage");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Post",
                newName: "recipeId");

            migrationBuilder.RenameColumn(
                name: "Instruction",
                table: "Post",
                newName: "instructions");

            migrationBuilder.RenameColumn(
                name: "Ingriediants",
                table: "Post",
                newName: "ingreidants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "recipeName",
                table: "Post",
                newName: "RecipeName");

            migrationBuilder.RenameColumn(
                name: "recipeImage",
                table: "Post",
                newName: "RecipeImage");

            migrationBuilder.RenameColumn(
                name: "recipeId",
                table: "Post",
                newName: "RecipeId");

            migrationBuilder.RenameColumn(
                name: "instructions",
                table: "Post",
                newName: "Instruction");

            migrationBuilder.RenameColumn(
                name: "ingreidants",
                table: "Post",
                newName: "Ingriediants");
        }
    }
}
