using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class editdatetometable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromDate",
                table: "TimeTable");

            migrationBuilder.RenameColumn(
                name: "ToDate",
                table: "TimeTable",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "TimeTable",
                newName: "ToDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "FromDate",
                table: "TimeTable",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
