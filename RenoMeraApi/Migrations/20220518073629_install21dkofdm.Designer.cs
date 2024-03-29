﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RenoMeraApi.Persistence;

#nullable disable

namespace RenoMeraApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220518073629_install21dkofdm")]
    partial class install21dkofdm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RenoMeraApi.Domain.Models.ConstructionPost", b =>
                {
                    b.Property<int>("ConstructionPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConstructionPostId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConstructionPostId");

                    b.ToTable("constructionPosts");

                    b.HasData(
                        new
                        {
                            ConstructionPostId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Image = "https://www.house-extension.co.uk/wp-content/uploads/2016/02/old-door-683x1024.jpg",
                            Phone = "0739888159",
                            UserId = "61be864a-ee0a-41ee-b9ee-e9e5f8acb36b",
                            title = "Looking for tools"
                        },
                        new
                        {
                            ConstructionPostId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Image = "https://www.cornwallbuildingsupplies.com/wp-content/uploads/2020/08/tools-01.jpg",
                            Phone = "0739888159",
                            UserId = "61be864a-ee0a-41ee-b9ee-e9e5f8acb36b",
                            title = "Looking for these hammers"
                        });
                });

            modelBuilder.Entity("RenoMeraApi.Domain.Models.CustomerPost", b =>
                {
                    b.Property<int>("CustomerPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerPostId"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerPostId");

                    b.ToTable("customerPosts");

                    b.HasData(
                        new
                        {
                            CustomerPostId = 1,
                            City = "Linköping",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Image = "https://get.pxhere.com/photo/wood-house-texture-window-old-wall-rural-abandoned-empty-brick-lumber-door-weathered-dilapidated-wooden-aged-urban-area-1380478.jpg",
                            PhoneNumber = "0739888159",
                            Title = "Need Help with my old house wall",
                            UserId = "25146d76-1f61-46db-90af-15c169f7e522"
                        },
                        new
                        {
                            CustomerPostId = 2,
                            City = "Linköping",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Image = "https://www.house-extension.co.uk/wp-content/uploads/2016/02/old-door-683x1024.jpg",
                            PhoneNumber = "0739888159",
                            Title = "Need Help with this door",
                            UserId = "25146d76-1f61-46db-90af-15c169f7e522"
                        });
                });

            modelBuilder.Entity("RenoMeraApi.Domain.Models.SupplierPost", b =>
                {
                    b.Property<int>("SupplierPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierPostId"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierPostId");

                    b.ToTable("supplierPosts");

                    b.HasData(
                        new
                        {
                            SupplierPostId = 1,
                            City = "Linköping",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Image = "https://www.lassesiryd.se/pub_images/large/700405.jpg",
                            Phone = "0739888159",
                            Price = 75.0,
                            UserId = "d34ecc0a-1f48-47b9-a728-f93fe1aedcd7",
                            title = "Buy now at half the price"
                        },
                        new
                        {
                            SupplierPostId = 2,
                            City = "Linköping",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Image = "https://th.bing.com/th/id/OIP.C0Y25ccnnRv-KsXdfFXIeAAAAA?pid=ImgDet&rs=1",
                            Phone = "0739888159",
                            Price = 99.0,
                            UserId = "d34ecc0a-1f48-47b9-a728-f93fe1aedcd7",
                            title = "Amazing second hand building tools"
                        });
                });

            modelBuilder.Entity("RenoMeraApi.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = "25146d76-1f61-46db-90af-15c169f7e522",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba7e7f71-f0ed-49e1-b136-78da4a56b7e4",
                            Email = "Customer@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@GMAIL.COM",
                            NormalizedUserName = "CUSTOMER",
                            PasswordHash = "AQAAAAEAACcQAAAAEA9wNYsfVS0mPs9ljC770fpeA0267/Z0L6ALdrBrYaB6UPVS30XaIdg7A4bg7DDxYw==",
                            PhoneNumberConfirmed = false,
                            Role = "customer",
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserId = 0,
                            UserName = "Customer"
                        },
                        new
                        {
                            Id = "61be864a-ee0a-41ee-b9ee-e9e5f8acb36b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "851499f4-647e-447b-afed-fe2b22074fc7",
                            Email = "Construction@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CONSTRUCTION@GMAIL.COM",
                            NormalizedUserName = "CONSTRUCTION",
                            PasswordHash = "AQAAAAEAACcQAAAAEAVI15uhjoNPH43vYBLeCd2fUA/c0uGQKkraRRJC0gDSKmxQhP2gNIcpQ2YRxsHHrQ==",
                            PhoneNumberConfirmed = false,
                            Role = "construction",
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserId = 0,
                            UserName = "Construction"
                        },
                        new
                        {
                            Id = "d34ecc0a-1f48-47b9-a728-f93fe1aedcd7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e950cec7-61e2-4348-bd2d-5ad20140a12d",
                            Email = "Supplier@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPPLIER@GMAIL.COM",
                            NormalizedUserName = "SUPPLIER",
                            PasswordHash = "AQAAAAEAACcQAAAAEIQ0sDFJ2E7xeYEtgUU05iRz1BIEoOcjvi3QTpxLh4zFDoX38RY8fmQqRGB0lZJjCA==",
                            PhoneNumberConfirmed = false,
                            Role = "supplier",
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserId = 0,
                            UserName = "Supplier"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
