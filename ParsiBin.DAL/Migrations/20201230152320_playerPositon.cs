using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsiBin.DAL.Migrations
{
    public partial class playerPositon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RetirementDate",
                table: "Player",
                type: "datetime2",
                nullable: true);

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropColumn(
                name: "RetirementDate",
                table: "Player");
        }
    }
}
