using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class addcusinclassfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerInTimeTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TimeTableId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInTimeTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerInTimeTable_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerInTimeTable_TimeTable_TimeTableId",
                        column: x => x.TimeTableId,
                        principalTable: "TimeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInTimeTable_CustomerId",
                table: "CustomerInTimeTable",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInTimeTable_TimeTableId",
                table: "CustomerInTimeTable",
                column: "TimeTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerInTimeTable");
        }
    }
}
