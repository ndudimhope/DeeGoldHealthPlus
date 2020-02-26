using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeeGoldHealthPlus.Migrations
{
    public partial class SeededDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://ndudimhope.blob.core.windows.net/deegoldhealth/BERRYOIL_opt.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/BERRYOIL.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Green-Tea-1_opt.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Green-Tea-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Slimming-Tea_opt.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Slimming-Tea.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek" },
                values: new object[] { "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Vintage-Wine_opt.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Vintage-Wine.jpg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian_opt.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek", "LongDescription", "ProductName", "ShortDescription" },
                values: new object[] { "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules_opt.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules.jpg", true, "Effective in the treatment of ulcer, both early and acute", "GI-VITAL ULCER CAPSULES", "For the complete treatment of ulcer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-products-Mouth-Freshener_opt.jpg", "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-products-Mouth-Freshener.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek" },
                values: new object[] { "", "", false });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek", "LongDescription", "ProductName", "ShortDescription" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", false, "Effective in the treatment of stroke,athritis and rheumatism and also helps to boost the immune system", "Longrich Arthro SupReviver", "UNISEX" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek" },
                values: new object[] { null, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true });
        }
    }
}
