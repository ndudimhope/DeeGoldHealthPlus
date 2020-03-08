using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeeGoldHealthPlus.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsProductOfTheWeek = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "General", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "WellBeing", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Treatment", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek", "LongDescription", "Price", "ProductName", "ShortDescription" },
                values: new object[,]
                {
                    { 7, 1, "https://ndudimhope.blob.core.windows.net/deegoldhealth/mouth%20freshner%20small.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-products-Mouth-Freshener.jpg", false, "A mouth spuray to keep your breath fresh, and your healthy", 1100.00m, "Longrich Mouth Freshner", "Keeps your mouth fresh and health" },
                    { 1, 2, "https://ndudimhope.blob.core.windows.net/deegoldhealth/berryoil%20small.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/BERRYOIL.jpg", true, "Rich in Omega 3,6,7 & 9 Protects the liver, heart and kidney", 13100.00m, "Longrich BerryOil", "Shenxing Seabuckthorn" },
                    { 2, 2, "https://ndudimhope.blob.core.windows.net/deegoldhealth/greentea%20small.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Green-Tea-1.jpg", false, "It is a very good dietary option containing detoxifier and anti-carcinogens", 2950.00m, "Longrich GreenTea", "Xinchang Tea" },
                    { 3, 2, "https://ndudimhope.blob.core.windows.net/deegoldhealth/slimming%20tea.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Slimming-Tea.jpg", false, "Increases fat burning and improves physical performance", 2950.00m, "Longrich Slimming Tea", "Slimming/Pink Tea" },
                    { 4, 2, "https://ndudimhope.blob.core.windows.net/deegoldhealth/vintage%20wine%20small.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Vintage-Wine.jpg", true, "Increases fat burning and improves physical performance", 7800.00m, "Longrich Vintage Wine", "100% Natural & Medicinal" },
                    { 5, 2, "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian%20small.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian.jpg", false, "It corrects hormonal imbalance, it is anti-aging", 9800.00m, "Longrich Mengquian", "Fertility Supplement for Women" },
                    { 6, 3, "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules%20small.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules.jpg", true, "Effective in the treatment of ulcer, both early and acute", 9000.00m, "GI-VITAL ULCER CAPSULES", "For the complete treatment of ulcer" },
                    { 8, 3, "", "", false, "Treats over 200 diseases", 25000.00m, "PhytoScience Stem-cell", "Double Stemcell" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
