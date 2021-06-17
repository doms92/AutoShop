using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    AutoPartsId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_AutoParts_AutoPartsId",
                        column: x => x.AutoPartsId,
                        principalTable: "AutoParts",
                        principalColumn: "AutoPartsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "\\Images\\thumbnails\\pi.jpg", "\\Images\\", 335.00m });

            migrationBuilder.UpdateData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "\\Images\\thumbnails\\eng.jpg", "\\Images\\engine.jpg", 1000.00m });

            migrationBuilder.UpdateData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "\\Images\\thumbnails\\alt.jpg", "\\Images\\alternator.jpg", 222.00m });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_AutoPartsId",
                table: "ShoppingCartItems",
                column: "AutoPartsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "", "`\\images\\pzero.jpg", 4.95m });

            migrationBuilder.UpdateData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "", "`\\images\\engine.jpg", 4.95m });

            migrationBuilder.UpdateData(
                table: "AutoParts",
                keyColumn: "AutoPartsId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "", "`\\images\\alternator.jpg", 4.95m });
        }
    }
}
