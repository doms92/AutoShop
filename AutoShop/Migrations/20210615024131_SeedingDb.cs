using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AutoParts",
                columns: new[] { "AutoPartsId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price", "WorkOrdersWorkOrderId" },
                values: new object[,]
                {
                    { 1, 1, "Pirelli, Foreign", "", "\\images\\pzero.jpg", true, false, "Pirelli Tires", 4.95m, null },
                    { 2, 1, "USA Engine", "", "\\images\\engine.jpg", true, false, "Stock Engine", 4.95m, null },
                    { 3, 1, "USA Alternator", "", "\\images\\alternator.jpg", true, true, "Stock Alternator", 4.95m, null }
                });

            migrationBuilder.InsertData(
                table: "workOrders",
                columns: new[] { "WorkOrderId", "WorkOrderDescription", "WorkOrderName" },
                values: new object[,]
                {
                    { 1, null, "Tire" },
                    { 2, null, "Engine" },
                    { 3, null, "Alternator" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "workOrders",
                keyColumn: "WorkOrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "workOrders",
                keyColumn: "WorkOrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "workOrders",
                keyColumn: "WorkOrderId",
                keyValue: 3);
        }
    }
}
