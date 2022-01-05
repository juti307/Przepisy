using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt3.Data.Migrations
{
    public partial class n4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "like",
                table: "Recipe",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "like",
                table: "Recipe");
        }
    }
}
