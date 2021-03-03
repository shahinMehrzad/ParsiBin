using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsiBin.DAL.Migrations
{
    public partial class MatchResultState2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AwayTeam_Passes",
                table: "MatchResultState",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeTeam_Passes",
                table: "MatchResultState",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayTeam_Passes",
                table: "MatchResultState");

            migrationBuilder.DropColumn(
                name: "HomeTeam_Passes",
                table: "MatchResultState");
        }
    }
}
