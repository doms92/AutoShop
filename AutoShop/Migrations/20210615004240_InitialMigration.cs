using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workOrders",
                columns: table => new
                {
                    WorkOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkOrderName = table.Column<string>(nullable: true),
                    WorkOrderDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workOrders", x => x.WorkOrderId);
                });

            migrationBuilder.CreateTable(
                name: "AutoParts",
                columns: table => new
                {
                    AutoPartsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsOnSale = table.Column<bool>(nullable: false),
                    IsInStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    WorkOrdersWorkOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoParts", x => x.AutoPartsId);
                    table.ForeignKey(
                        name: "FK_AutoParts_workOrders_WorkOrdersWorkOrderId",
                        column: x => x.WorkOrdersWorkOrderId,
                        principalTable: "workOrders",
                        principalColumn: "WorkOrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoParts_WorkOrdersWorkOrderId",
                table: "AutoParts",
                column: "WorkOrdersWorkOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoParts");

            migrationBuilder.DropTable(
                name: "workOrders");
        }
    }
}
