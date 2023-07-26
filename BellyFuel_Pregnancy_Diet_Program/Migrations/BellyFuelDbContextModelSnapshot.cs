﻿// <auto-generated />
using System;
using BellyFuel_Pregnancy_Diet_Program.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BellyFuel_Pregnancy_Diet_Program.Migrations
{
    [DbContext(typeof(BellyFuelDbContext))]
    partial class BellyFuelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Beverage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("Carbs")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("Sodium")
                        .HasColumnType("float");

                    b.Property<double>("Sugar")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Beverages");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.BeverageCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BeverageCategories");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("Carbs")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("Photo")
                        .HasMaxLength(255)
                        .HasColumnType("varbinary(255)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("Sodium")
                        .HasColumnType("float");

                    b.Property<double>("Sugar")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsPregnant")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.UserBeverage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BeverageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeverageId");

                    b.HasIndex("MealId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBeverages");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.UserFood", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FoodId");

                    b.HasIndex("FoodId");

                    b.HasIndex("MealId");

                    b.ToTable("UserFoods");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Beverage", b =>
                {
                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.BeverageCategory", "Category")
                        .WithMany("Beverages")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Food", b =>
                {
                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.FoodCategory", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.User", b =>
                {
                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.UserBeverage", b =>
                {
                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.Beverage", "Beverage")
                        .WithMany("UserBeverages")
                        .HasForeignKey("BeverageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.Meal", "Meal")
                        .WithMany("UserBeverages")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.User", "User")
                        .WithMany("UserBeverages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beverage");

                    b.Navigation("Meal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.UserFood", b =>
                {
                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.Food", "Food")
                        .WithMany("UserFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.Meal", "Meal")
                        .WithMany("UserFoods")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BellyFuel_Pregnancy_Diet_Program.Data.User", "User")
                        .WithMany("UserFoods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Meal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Beverage", b =>
                {
                    b.Navigation("UserBeverages");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.BeverageCategory", b =>
                {
                    b.Navigation("Beverages");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Food", b =>
                {
                    b.Navigation("UserFoods");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Meal", b =>
                {
                    b.Navigation("UserBeverages");

                    b.Navigation("UserFoods");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BellyFuel_Pregnancy_Diet_Program.Data.User", b =>
                {
                    b.Navigation("UserBeverages");

                    b.Navigation("UserFoods");
                });
#pragma warning restore 612, 618
        }
    }
}
