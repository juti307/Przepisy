using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt3.Data.Migrations
{
    public partial class New3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Recipe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Recipe");
        }
    }
}
