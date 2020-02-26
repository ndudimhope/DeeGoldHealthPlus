﻿// <auto-generated />
using System;
using DeeGoldHealthPlus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeeGoldHealthPlus.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeeGoldHealthPlus.models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "General"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "WellBeing"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Treatment"
                        });
                });

            modelBuilder.Entity("DeeGoldHealthPlus.models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DeeGoldHealthPlus.models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("DeeGoldHealthPlus.models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/BERRYOIL_opt.jpg",
                            ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/BERRYOIL.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "Rich in Omega 3,6,7 & 9 Protects the liver, heart and kidney",
                            Price = 13100.00m,
                            ProductName = "Longrich BerryOil",
                            ShortDescription = "Shenxing Seabuckthorn"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Green-Tea-1_opt.jpg",
                            ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Green-Tea-1.jpg",
                            IsProductOfTheWeek = false,
                            LongDescription = "It is a very good dietary option containing detoxifier and anti-carcinogens",
                            Price = 2950.00m,
                            ProductName = "Longrich GreenTea",
                            ShortDescription = "Xinchang Tea"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Slimming-Tea_opt.jpg",
                            ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Slimming-Tea.jpg",
                            IsProductOfTheWeek = false,
                            LongDescription = "Increases fat burning and improves physical performance",
                            Price = 2950.00m,
                            ProductName = "Longrich Slimming Tea",
                            ShortDescription = "Slimming/Pink Tea"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Vintage-Wine_opt.jpg",
                            ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-Nigeria-Products-Vintage-Wine.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "Increases fat burning and improves physical performance",
                            Price = 7800.00m,
                            ProductName = "Longrich Vintage Wine",
                            ShortDescription = "100% Natural & Medicinal"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian_opt.jpg",
                            ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/mengquian.jpg",
                            IsProductOfTheWeek = false,
                            LongDescription = "It corrects hormonal imbalance, it is anti-aging",
                            Price = 9800.00m,
                            ProductName = "Longrich Mengquian",
                            ShortDescription = "Fertility Supplement for Women"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules_opt.jpg",
                            ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/ulcer%20capsules.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "Effective in the treatment of ulcer, both early and acute",
                            Price = 9000.00m,
                            ProductName = "GI-VITAL ULCER CAPSULES",
                            ShortDescription = "For the complete treatment of ulcer"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-products-Mouth-Freshener_opt.jpg",
                            ImageUrl = "https://ndudimhope.blob.core.windows.net/deegoldhealth/Longrich-products-Mouth-Freshener.jpg",
                            IsProductOfTheWeek = false,
                            LongDescription = "A mouth spuray to keep your breath fresh, and your healthy",
                            Price = 1100.00m,
                            ProductName = "Longrich Mouth Freshner",
                            ShortDescription = "Keeps your mouth fresh and health"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsProductOfTheWeek = false,
                            LongDescription = "Treats over 200 diseases",
                            Price = 25000.00m,
                            ProductName = "PhytoScience Stem-cell",
                            ShortDescription = "Double Stemcell"
                        });
                });

            modelBuilder.Entity("DeeGoldHealthPlus.models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("DeeGoldHealthPlus.models.OrderDetail", b =>
                {
                    b.HasOne("DeeGoldHealthPlus.models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeeGoldHealthPlus.models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DeeGoldHealthPlus.models.Product", b =>
                {
                    b.HasOne("DeeGoldHealthPlus.models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DeeGoldHealthPlus.models.ShoppingCartItem", b =>
                {
                    b.HasOne("DeeGoldHealthPlus.models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
