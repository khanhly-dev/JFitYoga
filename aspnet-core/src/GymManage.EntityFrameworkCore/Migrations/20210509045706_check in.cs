using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class checkin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerInTrainingClass");

            migrationBuilder.DropTable(
                name: "EmployeeInTrainingClass");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerInTrainingClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TrainingClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInTrainingClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerInTrainingClass_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerInTrainingClass_TrainingClass_TrainingClassId",
                        column: x => x.TrainingClassId,
                        principalTable: "TrainingClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInTrainingClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TrainingClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInTrainingClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeInTrainingClass_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInTrainingClass_TrainingClass_TrainingClassId",
                        column: x => x.TrainingClassId,
                        principalTable: "TrainingClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInTrainingClass_CustomerId",
                table: "CustomerInTrainingClass",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInTrainingClass_TrainingClassId",
                table: "CustomerInTrainingClass",
                column: "TrainingClassId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInTrainingClass_EmployeeId",
                table: "EmployeeInTrainingClass",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInTrainingClass_TrainingClassId",
                table: "EmployeeInTrainingClass",
                column: "TrainingClassId");
        }
    }
}
