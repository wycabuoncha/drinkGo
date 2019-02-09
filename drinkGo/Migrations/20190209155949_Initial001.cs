using Microsoft.EntityFrameworkCore.Migrations;

namespace drinkGo.Migrations
{
    public partial class Initial001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_drinkGO_Category_CategoryId",
                table: "Drinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drinkGO_Category",
                table: "drinkGO_Category");

            migrationBuilder.RenameTable(
                name: "drinkGO_Category",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Category_CategoryId",
                table: "Drinks",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Category_CategoryId",
                table: "Drinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "drinkGO_Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drinkGO_Category",
                table: "drinkGO_Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_drinkGO_Category_CategoryId",
                table: "Drinks",
                column: "CategoryId",
                principalTable: "drinkGO_Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
