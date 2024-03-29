﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RenoMeraApi.Migrations
{
    public partial class install21dkofdm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "constructionPosts",
                columns: table => new
                {
                    ConstructionPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_constructionPosts", x => x.ConstructionPostId);
                });

            migrationBuilder.CreateTable(
                name: "customerPosts",
                columns: table => new
                {
                    CustomerPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerPosts", x => x.CustomerPostId);
                });

            migrationBuilder.CreateTable(
                name: "supplierPosts",
                columns: table => new
                {
                    SupplierPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplierPosts", x => x.SupplierPostId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "constructionPosts",
                columns: new[] { "ConstructionPostId", "Description", "Image", "Phone", "UserId", "title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "https://www.house-extension.co.uk/wp-content/uploads/2016/02/old-door-683x1024.jpg", "0739888159", "61be864a-ee0a-41ee-b9ee-e9e5f8acb36b", "Looking for tools" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "https://www.cornwallbuildingsupplies.com/wp-content/uploads/2020/08/tools-01.jpg", "0739888159", "61be864a-ee0a-41ee-b9ee-e9e5f8acb36b", "Looking for these hammers" }
                });

            migrationBuilder.InsertData(
                table: "customerPosts",
                columns: new[] { "CustomerPostId", "City", "Description", "Image", "PhoneNumber", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Linköping", "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "https://get.pxhere.com/photo/wood-house-texture-window-old-wall-rural-abandoned-empty-brick-lumber-door-weathered-dilapidated-wooden-aged-urban-area-1380478.jpg", "0739888159", "Need Help with my old house wall", "25146d76-1f61-46db-90af-15c169f7e522" },
                    { 2, "Linköping", "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "https://www.house-extension.co.uk/wp-content/uploads/2016/02/old-door-683x1024.jpg", "0739888159", "Need Help with this door", "25146d76-1f61-46db-90af-15c169f7e522" }
                });

            migrationBuilder.InsertData(
                table: "supplierPosts",
                columns: new[] { "SupplierPostId", "City", "Description", "Image", "Phone", "Price", "UserId", "title" },
                values: new object[,]
                {
                    { 1, "Linköping", "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "https://www.lassesiryd.se/pub_images/large/700405.jpg", "0739888159", 75.0, "d34ecc0a-1f48-47b9-a728-f93fe1aedcd7", "Buy now at half the price" },
                    { 2, "Linköping", "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "https://th.bing.com/th/id/OIP.C0Y25ccnnRv-KsXdfFXIeAAAAA?pid=ImgDet&rs=1", "0739888159", 99.0, "d34ecc0a-1f48-47b9-a728-f93fe1aedcd7", "Amazing second hand building tools" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "25146d76-1f61-46db-90af-15c169f7e522", 0, "ba7e7f71-f0ed-49e1-b136-78da4a56b7e4", "Customer@gmail.com", true, false, null, "CUSTOMER@GMAIL.COM", "CUSTOMER", null, "AQAAAAEAACcQAAAAEA9wNYsfVS0mPs9ljC770fpeA0267/Z0L6ALdrBrYaB6UPVS30XaIdg7A4bg7DDxYw==", null, false, "customer", "", false, 0, "Customer" },
                    { "61be864a-ee0a-41ee-b9ee-e9e5f8acb36b", 0, "851499f4-647e-447b-afed-fe2b22074fc7", "Construction@gmail.com", true, false, null, "CONSTRUCTION@GMAIL.COM", "CONSTRUCTION", null, "AQAAAAEAACcQAAAAEAVI15uhjoNPH43vYBLeCd2fUA/c0uGQKkraRRJC0gDSKmxQhP2gNIcpQ2YRxsHHrQ==", null, false, "construction", "", false, 0, "Construction" },
                    { "d34ecc0a-1f48-47b9-a728-f93fe1aedcd7", 0, "e950cec7-61e2-4348-bd2d-5ad20140a12d", "Supplier@gmail.com", true, false, null, "SUPPLIER@GMAIL.COM", "SUPPLIER", null, "AQAAAAEAACcQAAAAEIQ0sDFJ2E7xeYEtgUU05iRz1BIEoOcjvi3QTpxLh4zFDoX38RY8fmQqRGB0lZJjCA==", null, false, "supplier", "", false, 0, "Supplier" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "constructionPosts");

            migrationBuilder.DropTable(
                name: "customerPosts");

            migrationBuilder.DropTable(
                name: "supplierPosts");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
