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
                    { 7, 1, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, "A mouth spuray to keep your breath fresh, and your healthy", 1100.00m, "Longrich Mouth Freshner", "Keeps your mouth fresh and health" },
                    { 1, 2, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, "Rich in Omega 3,6,7 & 9 Protects the liver, heart and kidney", 13100.00m, "Longrich BerryOil", "Shenxing Seabuckthorn" },
                    { 2, 2, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", false, "It is a very good dietary option containing detoxifier and anti-carcinogens", 2950.00m, "Longrich GreenTea", "Xinchang Tea" },
                    { 3, 2, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jp", false, "Increases fat burning and improves physical performance", 2950.00m, "Longrich Slimming Tea", "Slimming/Pink Tea" },
                    { 4, 2, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", false, "Increases fat burning and improves physical performance", 7800.00m, "Longrich Vintage Wine", "100% Natural & Medicinal" },
                    { 5, 2, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", false, "It corrects hormonal imbalance, it is anti-aging", 9800.00m, "Longrich Mengquian", "Fertility Supplement for Women" },
                    { 6, 3, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", false, "Effective in the treatment of stroke,athritis and rheumatism and also helps to boost the immune system", 9000.00m, "Longrich Arthro SupReviver", "UNISEX" },
                    { 8, 3, null, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, "Treats over 200 diseases", 25000.00m, "PhytoScience Stem-cell", "Double Stemcell" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
