using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class editoption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Option",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Option",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Option");
        }
    }
}
