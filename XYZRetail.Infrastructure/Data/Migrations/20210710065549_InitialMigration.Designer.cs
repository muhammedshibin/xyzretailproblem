// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XYZRetail.Infrastructure.Data;

namespace XYZRetail.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210710065549_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XYZRetail.Core.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<decimal>("ItemBasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ItemNetPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ImportTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalesTax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Book",
                            ImportTax = 0m,
                            SalesTax = 0m
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "CD",
                            ImportTax = 0.05m,
                            SalesTax = 0.1m
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Cosmetics",
                            ImportTax = 0m,
                            SalesTax = 0.1m
                        });
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 100m,
                            CategoryId = 1,
                            PictureUrl = "images/Book-1.jpg",
                            ProductName = "Book - 1"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 150m,
                            CategoryId = 1,
                            PictureUrl = "images/Book-2.jpg",
                            ProductName = "Book - 2"
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 120m,
                            CategoryId = 1,
                            PictureUrl = "images/Book-3.jpg",
                            ProductName = "Book - 3"
                        },
                        new
                        {
                            Id = 4,
                            BasePrice = 40m,
                            CategoryId = 2,
                            PictureUrl = "images/cd-1.jpg",
                            ProductName = "CD - 1"
                        },
                        new
                        {
                            Id = 5,
                            BasePrice = 50m,
                            CategoryId = 2,
                            PictureUrl = "images/cd-2.jpg",
                            ProductName = "CD - 2"
                        },
                        new
                        {
                            Id = 6,
                            BasePrice = 60m,
                            CategoryId = 2,
                            PictureUrl = "images/cd-3.jpg",
                            ProductName = "CD - 3"
                        },
                        new
                        {
                            Id = 7,
                            BasePrice = 250m,
                            CategoryId = 3,
                            PictureUrl = "images/cosmetics-1.jpg",
                            ProductName = "Cosmetics - 1"
                        },
                        new
                        {
                            Id = 8,
                            BasePrice = 300m,
                            CategoryId = 3,
                            PictureUrl = "images/cosmetics-2.jpg",
                            ProductName = "Cosmetics - 2"
                        });
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.Basket", b =>
                {
                    b.HasOne("XYZRetail.Core.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.BasketItem", b =>
                {
                    b.HasOne("XYZRetail.Core.Entities.Basket", "Basket")
                        .WithMany("Items")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.Product", b =>
                {
                    b.HasOne("XYZRetail.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("XYZRetail.Core.Entities.Basket", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
