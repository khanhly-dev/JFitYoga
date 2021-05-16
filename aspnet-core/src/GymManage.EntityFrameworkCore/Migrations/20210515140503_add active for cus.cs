using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class addactiveforcus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "CustomerInTimeTable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Born", "FromDate" },
                values: new object[] { new DateTime(2021, 5, 15, 21, 5, 2, 747, DateTimeKind.Local).AddTicks(9849), new DateTime(2021, 5, 15, 21, 5, 2, 748, DateTimeKind.Local).AddTicks(9147) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "CustomerInTimeTable");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Born", "FromDate" },
                values: new object[] { new DateTime(2021, 5, 14, 22, 6, 28, 817, DateTimeKind.Local).AddTicks(4984), new DateTime(2021, 5, 14, 22, 6, 28, 818, DateTimeKind.Local).AddTicks(4241) });
        }
    }
}
