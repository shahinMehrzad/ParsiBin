using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsiBin.DAL.Migrations
{
    public partial class MatchResultState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchResultState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchResultId = table.Column<int>(type: "int", nullable: true),
                    HomeTeam_Possession = table.Column<double>(type: "float", nullable: false),
                    AwayTeam_Possession = table.Column<double>(type: "float", nullable: false),
                    HomeTeam_Total_Shots = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Total_Shots = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_On_Target_Shots = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_On_Target_Shots = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Of_Target_Shots = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Of_Target_Shots = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Blocked_Shots = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Blocked_Shots = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Passing_Percentage = table.Column<double>(type: "float", nullable: false),
                    AwayTeam_Passing_Percentage = table.Column<double>(type: "float", nullable: false),
                    HomeTeam_Clear_Cut_Chances = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Clear_Cut_Chances = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Corners = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Corners = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Offsides = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Offsides = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Tackles_Percentage = table.Column<double>(type: "float", nullable: false),
                    AwayTeam_Tackles_Percentage = table.Column<double>(type: "float", nullable: false),
                    HomeTeam_Aerial_Duels_Percentage = table.Column<double>(type: "float", nullable: false),
                    AwayTeam_Aerial_Duels_Percentage = table.Column<double>(type: "float", nullable: false),
                    HomeTeam_Saves = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Saves = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Fouls_Committed = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Fouls_Committed = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Fouls_Won = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Fouls_Won = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Yellow_Cards = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Yellow_Cards = table.Column<int>(type: "int", nullable: false),
                    HomeTeam_Red_Cards = table.Column<int>(type: "int", nullable: false),
                    AwayTeam_Red_Cards = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchResultState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchResultState_MatchResult_MatchResultId",
                        column: x => x.MatchResultId,
                        principalTable: "MatchResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchResultDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchResultId = table.Column<int>(type: "int", nullable: true),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true),
                    ActionTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchResultDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchResultDetail_ActionType_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchResultDetail_MatchResult_MatchResultId",
                        column: x => x.MatchResultId,
                        principalTable: "MatchResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchResultDetail_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchResultDetail_ActionTypeId",
                table: "MatchResultDetail",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchResultDetail_MatchResultId",
                table: "MatchResultDetail",
                column: "MatchResultId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchResultDetail_PlayerId",
                table: "MatchResultDetail",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchResultState_MatchResultId",
                table: "MatchResultState",
                column: "MatchResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchResultDetail");

            migrationBuilder.DropTable(
                name: "MatchResultState");

            migrationBuilder.DropTable(
                name: "ActionType");
        }
    }
}
