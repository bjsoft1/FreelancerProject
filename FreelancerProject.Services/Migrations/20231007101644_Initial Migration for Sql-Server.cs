using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreelancerProject.Services.Migrations
{
    public partial class InitialMigrationforSqlServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    image = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationTime", "DeletionTime", "Description", "image", "IsActive", "IsDeleted", "ModificationTime", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50000"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/0.png", true, false, null, "My Product-0", 1500f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50001"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/1.png", true, false, null, "My Product-1", 1620f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50002"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/2.png", true, false, null, "My Product-2", 1740f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50003"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/3.png", true, false, null, "My Product-3", 1860f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50004"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/4.png", true, false, null, "My Product-4", 1980f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50005"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/5.png", true, false, null, "My Product-5", 2100f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50006"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/6.png", true, false, null, "My Product-6", 2220f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50007"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/7.png", true, false, null, "My Product-7", 2340f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50008"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/8.png", true, false, null, "My Product-8", 2460f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50009"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/9.png", true, false, null, "My Product-9", 2580f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50010"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/10.png", true, false, null, "My Product-10", 2700f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50011"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/11.png", true, false, null, "My Product-11", 2820f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50012"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/12.png", true, false, null, "My Product-12", 2940f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50013"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/13.png", true, false, null, "My Product-13", 3060f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50014"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/14.png", true, false, null, "My Product-14", 3180f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50015"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/15.png", true, false, null, "My Product-15", 3300f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50016"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/16.png", true, false, null, "My Product-16", 3420f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50017"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/17.png", true, false, null, "My Product-17", 3540f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50018"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/18.png", true, false, null, "My Product-18", 3660f },
                    { new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50019"), new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), null, null, "assets/images/products/19.png", true, false, null, "My Product-19", 3780f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
