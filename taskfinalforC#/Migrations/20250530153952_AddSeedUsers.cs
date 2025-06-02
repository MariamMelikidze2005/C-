using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskfinalforC_.Migrations
{
    public partial class AddSeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAssword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Clothing" },
                    { 4, "Toys" },
                    { 5, "Groceries" },
                    { 6, "Furniture" },
                    { 7, "Sports" },
                    { 8, "Health" },
                    { 9, "Beauty" },
                    { 10, "Automotive" },
                    { 11, "Pet Supplies" },
                    { 12, "Garden" },
                    { 13, "Music" },
                    { 14, "Office Supplies" },
                    { 15, "Art" },
                    { 16, "Photography" },
                    { 17, "Shoes" },
                    { 18, "Jewelry" },
                    { 19, "Video Games" },
                    { 20, "Home Decor" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PAssword", "UserName" },
                values: new object[] { 1, "admin123", "admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Smartphone", 899m },
                    { 2, 1, "Laptop", 1500m },
                    { 3, 2, "Sci-Fi Novel", 19.99m },
                    { 4, 2, "Children's Book", 12.50m },
                    { 5, 3, "T-Shirt", 25m },
                    { 6, 3, "Jacket", 60m },
                    { 7, 4, "Lego Set", 45m },
                    { 8, 4, "Board Game", 35m },
                    { 9, 5, "Milk", 3m },
                    { 10, 5, "Eggs", 2.50m },
                    { 11, 6, "Chair", 80m },
                    { 12, 6, "Desk", 150m },
                    { 13, 7, "Football", 20m },
                    { 14, 7, "Tennis Racket", 75m },
                    { 15, 8, "Vitamin C", 10m },
                    { 16, 9, "Shampoo", 8.99m },
                    { 17, 10, "Car Oil", 25.99m },
                    { 18, 11, "Dog Food", 40m },
                    { 19, 13, "Guitar", 300m },
                    { 20, 20, "Wall Clock", 50m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerName", "OrderDate", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "Nino Beridze", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, "Giorgi Mikeladze", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 3, "Lasha Kapanadze", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 4, "Salome Gagnidze", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 10 },
                    { 5, "Ana Chikhladze", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 6, "Nikoloz Tsertsvadze", new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 7, "Lizi Tabidze", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 8, "Mariam Shengelia", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 9, "Dato Mchedlishvili", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 10, "Eka Kapanadze", new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 6 },
                    { 11, "Gela Chanturia", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 12, "Tatia Kvantaliani", new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 13, "Beka Tsikarishvili", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 5 },
                    { 14, "Elene Akhvlediani", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 15, "Irakli Gelashvili", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 16, "Lali Papashvili", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 17, "Zaza Giorgadze", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 18, "Maia Metreveli", new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 19, "Tamar Kukava", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 20, "Natia Lomtatidze", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
