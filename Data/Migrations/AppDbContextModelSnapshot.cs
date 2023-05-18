﻿// <auto-generated />
using System;
using Data.ShopContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Models.AchivePoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PointValue")
                        .HasColumnType("int");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("AchivePoints");
                });

            modelBuilder.Entity("Data.Models.BillDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdBill")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BillsId");

                    b.HasIndex("ShoeDetailsId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("Data.Models.Bills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CouponsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaymentMethodsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShipAdressMethodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CouponsId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PaymentMethodsId");

                    b.HasIndex("ShipAdressMethodId");

                    b.HasIndex("UsersId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Data.Models.Brands", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Data.Models.CartDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCart")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CartsId");

                    b.HasIndex("ShoeDetailsId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("Data.Models.Carts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Data.Models.Categories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Data.Models.Color_ShoeDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdColor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ColorsId");

                    b.HasIndex("ShoeDetailsId");

                    b.ToTable("Color_ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Colors", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Data.Models.Coupons", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DiscountValue")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("VoucherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("Data.Models.Descriptions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShoeDetailsId");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("Data.Models.FavouriteShoes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShoeDetailsId");

                    b.HasIndex("UsersId");

                    b.ToTable("FavouriteShoes");
                });

            modelBuilder.Entity("Data.Models.Feedbacks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingStar")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShoeDetailsId");

                    b.HasIndex("UsersId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Data.Models.Images", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageSource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShoeDetailsId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Data.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Data.Models.PaymentMethods", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("Data.Models.Roles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Data.Models.Sales", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DiscountValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SaleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Data.Models.ShipAdressMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShipAdressMethods");
                });

            modelBuilder.Entity("Data.Models.ShoeDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("BrandsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CostPrice")
                        .HasColumnType("int");

                    b.Property<Guid>("IdBrand")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCategory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSale")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSupplier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SalesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SellPrice")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BrandsId");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("SalesId");

                    b.HasIndex("SupplierId");

                    b.ToTable("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Sizes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("SizeNumber")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Data.Models.Sizes_ShoeDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdShoeDetails")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShoeDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SizesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShoeDetailsId");

                    b.HasIndex("SizesId");

                    b.ToTable("Sizes_ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Data.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RolesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RolesId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Data.Models.AchivePoint", b =>
                {
                    b.HasOne("Data.Models.Users", "Users")
                        .WithMany("AchivePoints")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Data.Models.BillDetails", b =>
                {
                    b.HasOne("Data.Models.Bills", "Bills")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("BillDetails")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bills");

                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Bills", b =>
                {
                    b.HasOne("Data.Models.Coupons", "Coupons")
                        .WithMany("Bills")
                        .HasForeignKey("CouponsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Location", "Location")
                        .WithMany("Bills")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.PaymentMethods", "PaymentMethods")
                        .WithMany("Bills")
                        .HasForeignKey("PaymentMethodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.ShipAdressMethod", "ShipAdressMethod")
                        .WithMany("Bills")
                        .HasForeignKey("ShipAdressMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Users", "Users")
                        .WithMany("Bills")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coupons");

                    b.Navigation("Location");

                    b.Navigation("PaymentMethods");

                    b.Navigation("ShipAdressMethod");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Data.Models.CartDetails", b =>
                {
                    b.HasOne("Data.Models.Carts", "Carts")
                        .WithMany("CartDetails")
                        .HasForeignKey("CartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("CartDetails")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Carts", b =>
                {
                    b.HasOne("Data.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Data.Models.Color_ShoeDetails", b =>
                {
                    b.HasOne("Data.Models.Colors", "Colors")
                        .WithMany("Color_ShoeDetails")
                        .HasForeignKey("ColorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("Color_ShoeDetails")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colors");

                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Descriptions", b =>
                {
                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("Descriptions")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.FavouriteShoes", b =>
                {
                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("FavoriteShoes")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Users", "Users")
                        .WithMany("FavoriteShoes")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoeDetails");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Data.Models.Feedbacks", b =>
                {
                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Users", "Users")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoeDetails");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Data.Models.Images", b =>
                {
                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("Images")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.ShoeDetails", b =>
                {
                    b.HasOne("Data.Models.Brands", "Brands")
                        .WithMany("ShoeDetails")
                        .HasForeignKey("BrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Categories", "Categories")
                        .WithMany("ShoeDetails")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Sales", "Sales")
                        .WithMany("ShoeDetails")
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Supplier", "Supplier")
                        .WithMany("ShoeDetails")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brands");

                    b.Navigation("Categories");

                    b.Navigation("Sales");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Data.Models.Sizes_ShoeDetails", b =>
                {
                    b.HasOne("Data.Models.ShoeDetails", "ShoeDetails")
                        .WithMany("Sizes_ShoeDetails")
                        .HasForeignKey("ShoeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Sizes", "Sizes")
                        .WithMany("Sizes_ShoeDetails")
                        .HasForeignKey("SizesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoeDetails");

                    b.Navigation("Sizes");
                });

            modelBuilder.Entity("Data.Models.Users", b =>
                {
                    b.HasOne("Data.Models.Roles", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Data.Models.Bills", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("Data.Models.Brands", b =>
                {
                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Carts", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("Data.Models.Categories", b =>
                {
                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Colors", b =>
                {
                    b.Navigation("Color_ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Coupons", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Data.Models.Location", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Data.Models.PaymentMethods", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Data.Models.Roles", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Data.Models.Sales", b =>
                {
                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.ShipAdressMethod", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Data.Models.ShoeDetails", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetails");

                    b.Navigation("Color_ShoeDetails");

                    b.Navigation("Descriptions");

                    b.Navigation("FavoriteShoes");

                    b.Navigation("Feedbacks");

                    b.Navigation("Images");

                    b.Navigation("Sizes_ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Sizes", b =>
                {
                    b.Navigation("Sizes_ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Supplier", b =>
                {
                    b.Navigation("ShoeDetails");
                });

            modelBuilder.Entity("Data.Models.Users", b =>
                {
                    b.Navigation("AchivePoints");

                    b.Navigation("Bills");

                    b.Navigation("FavoriteShoes");

                    b.Navigation("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
