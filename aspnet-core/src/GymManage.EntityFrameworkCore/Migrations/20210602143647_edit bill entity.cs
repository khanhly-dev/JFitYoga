using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class editbillentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NgaySinh", "NgayBatDau" },
                values: new object[] { new DateTime(2021, 6, 2, 21, 36, 46, 499, DateTimeKind.Local).AddTicks(4428), new DateTime(2021, 6, 2, 21, 36, 46, 500, DateTimeKind.Local).AddTicks(5551) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NgaySinh", "NgayBatDau" },
                values: new object[] { new DateTime(2021, 5, 30, 22, 49, 28, 831, DateTimeKind.Local).AddTicks(3081), new DateTime(2021, 5, 30, 22, 49, 28, 832, DateTimeKind.Local).AddTicks(2283) });
        }
    }
}
