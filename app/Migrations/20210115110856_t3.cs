using Microsoft.EntityFrameworkCore.Migrations;

namespace teste.Migrations
{
    public partial class t3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CatSet",
                table: "CatSet");

            migrationBuilder.RenameTable(
                name: "CatSet",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CatSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatSet",
                table: "CatSet",
                column: "Id");
        }
    }
}
