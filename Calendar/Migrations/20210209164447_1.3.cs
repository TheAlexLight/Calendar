using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ChooseDateSelectedDate",
                table: "Calendars",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_ChooseDateSelectedDate",
                table: "Calendars",
                column: "ChooseDateSelectedDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Calendars_ChooseDateSelectedDate",
                table: "Calendars",
                column: "ChooseDateSelectedDate",
                principalTable: "Calendars",
                principalColumn: "SelectedDate",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Calendars_ChooseDateSelectedDate",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_ChooseDateSelectedDate",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "ChooseDateSelectedDate",
                table: "Calendars");
        }
    }
}
