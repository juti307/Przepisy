using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt3.Data.Migrations
{
    public partial class AddVotesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VoteAdded",
                table: "Recipe",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoteAdded",
                table: "Recipe");
        }
    }
}
