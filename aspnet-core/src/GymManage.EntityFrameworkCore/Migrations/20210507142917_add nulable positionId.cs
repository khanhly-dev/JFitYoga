using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class addnulablepositionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeePosition_PositionId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeePosition_PositionId",
                table: "Employee",
                column: "PositionId",
                principalTable: "EmployeePosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeePosition_PositionId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeePosition_PositionId",
                table: "Employee",
                column: "PositionId",
                principalTable: "EmployeePosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
