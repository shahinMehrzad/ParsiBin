using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsiBin.DAL.Migrations
{
    public partial class teamPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "Team",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeamCoach",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    CoachId = table.Column<int>(type: "int", nullable: true),
                    JoinDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LeftDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamCoach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamCoach_Coach_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamCoach_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    PlayerId = table.Column<int>(type: "int", nullable: true),
                    JoinDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LeftDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamPlayers_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamPlayers_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Team_CoachId",
                table: "Team",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamCoach_CoachId",
                table: "TeamCoach",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamCoach_TeamId",
                table: "TeamCoach",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayers_PlayerId",
                table: "TeamPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayers_TeamId",
                table: "TeamPlayers",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Coach_CoachId",
                table: "Team",
                column: "CoachId",
                principalTable: "Coach",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Coach_CoachId",
                table: "Team");

            migrationBuilder.DropTable(
                name: "TeamCoach");

            migrationBuilder.DropTable(
                name: "TeamPlayers");

            migrationBuilder.DropIndex(
                name: "IX_Team_CoachId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Team");
                        
            
        }
    }
}
