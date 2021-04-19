using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsiBin.DAL.Migrations
{
    public partial class TeamStadiumProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Stadium_StadiumId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_StadiumId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "StadiumId",
                table: "Team");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StadiumId",
                table: "Team",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_StadiumId",
                table: "Team",
                column: "StadiumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Stadium_StadiumId",
                table: "Team",
                column: "StadiumId",
                principalTable: "Stadium",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
