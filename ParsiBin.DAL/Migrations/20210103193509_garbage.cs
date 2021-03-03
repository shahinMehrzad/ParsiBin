using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsiBin.DAL.Migrations
{
    public partial class garbage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShirtNumber",
                table: "TeamPlayers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AwayTeam_Touches",
                table: "MatchResultState",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeTeam_Touches",
                table: "MatchResultState",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "MatchResultDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchResultDetail_TeamId",
                table: "MatchResultDetail",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResultDetail_Team_TeamId",
                table: "MatchResultDetail",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchResultDetail_Team_TeamId",
                table: "MatchResultDetail");

            migrationBuilder.DropIndex(
                name: "IX_MatchResultDetail_TeamId",
                table: "MatchResultDetail");

            migrationBuilder.DropColumn(
                name: "ShirtNumber",
                table: "TeamPlayers");

            migrationBuilder.DropColumn(
                name: "AwayTeam_Touches",
                table: "MatchResultState");

            migrationBuilder.DropColumn(
                name: "HomeTeam_Touches",
                table: "MatchResultState");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "MatchResultDetail");
        }
    }
}
