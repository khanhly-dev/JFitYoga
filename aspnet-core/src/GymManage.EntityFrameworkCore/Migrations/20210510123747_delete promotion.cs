using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class deletepromotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "ProductInPromotion");

            migrationBuilder.DropTable(
                name: "Promotion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplyForAll = table.Column<bool>(type: "bit", nullable: false),
                    DiscoutAmount = table.Column<int>(type: "int", nullable: false),
                    DiscoutPercent = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInPromotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInPromotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInPromotion_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInPromotion_Promotion_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInPromotion_ProductCategoryId",
                table: "ProductInPromotion",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInPromotion_PromotionId",
                table: "ProductInPromotion",
                column: "PromotionId");
        }
    }
}
