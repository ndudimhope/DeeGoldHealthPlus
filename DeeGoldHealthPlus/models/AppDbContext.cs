using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "General" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "WellBeing" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Treatment" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Longrich BerryOil",
                Price =13100.00M,
                ShortDescription = "Shenxing Seabuckthorn",
                LongDescription =
                    "Rich in Omega 3,6,7 & 9 Protects the liver, heart and kidney",
                CategoryId = 2,
                ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/BERRYOIL.jpg",
              
                IsProductOfTheWeek = true,
                ImageThumbnailUrl= "https://ndudimhope.blob.core.windows.net/deegoldhealth/BERRYOIL_opt.jpg",
                
                
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId =2,
                ProductName = "Longrich GreenTea",
                Price = 2950.00M,
                ShortDescription = "Xinchang Tea",
                LongDescription =
                    "It is a very good dietary option containing detoxifier and anti-carcinogens",
                CategoryId = 2,
                ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Green-Tea-1.jpg",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Green-Tea-1_opt.jpg",


            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                ProductName = "Longrich Slimming Tea",
                Price = 2950.00M,
                ShortDescription = "Slimming/Pink Tea",
                LongDescription =
                    "Increases fat burning and improves physical performance",
                CategoryId = 2,
                ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Slimming-Tea.jpg",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Slimming-Tea_opt.jpg",


            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                ProductName = "Longrich Vintage Wine",
                Price = 7800.00M,
                ShortDescription = "100% Natural & Medicinal",
                LongDescription =
                    "Increases fat burning and improves physical performance",
                CategoryId = 2,
                ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Vintage-Wine.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Vintage-Wine_opt.jpg",


            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                ProductName = "Longrich Mengquian",
                Price =9800.00M,
                ShortDescription = "Fertility Supplement for Women",
                LongDescription =
                    "It corrects hormonal imbalance, it is anti-aging",
                CategoryId = 2,
                ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian.jpg",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian_opt.jpg",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                ProductName = "GI-VITAL ULCER CAPSULES",
                Price = 9000.00M,
                ShortDescription = "For the complete treatment of ulcer",
                LongDescription =
                    "Effective in the treatment of ulcer, both early and acute",
                CategoryId = 3,
                ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules_opt.jpg",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                ProductName = "Longrich Mouth Freshner",
                Price = 1100.00M,
                ShortDescription = "Keeps your mouth fresh and health",
                LongDescription =
                    "A mouth spuray to keep your breath fresh, and your healthy",
                CategoryId = 1,
                ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-products-Mouth-Freshener.jpg",
              
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-products-Mouth-Freshener_opt.jpg",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                ProductName = "PhytoScience Stem-cell",
                Price = 25000.00M,
                ShortDescription = "Double Stemcell",
                LongDescription =
                    "Treats over 200 diseases",
                CategoryId = 3,
                ImageUrl = "",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "",

            });


            
        }
    }
}
