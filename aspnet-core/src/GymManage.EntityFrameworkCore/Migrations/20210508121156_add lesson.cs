using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class addlesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTable_TrainingClass_ClassId",
                table: "TimeTable");

            migrationBuilder.DropColumn(
                name: "FromDate",
                table: "TrainingClass");

            migrationBuilder.DropColumn(
                name: "ToDate",
                table: "TrainingClass");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "TimeTable",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lesson",
                table: "TimeTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTable_TrainingClass_ClassId",
                table: "TimeTable",
                column: "ClassId",
                principalTable: "TrainingClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTable_TrainingClass_ClassId",
                table: "TimeTable");

            migrationBuilder.DropColumn(
                name: "Lesson",
                table: "TimeTable");

            migrationBuilder.AddColumn<DateTime>(
                name: "FromDate",
                table: "TrainingClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ToDate",
                table: "TrainingClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "TimeTable",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTable_TrainingClass_ClassId",
                table: "TimeTable",
                column: "ClassId",
                principalTable: "TrainingClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
