using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "IdCategory", "Name" },
                values: new object[,]
                {
                    { new Guid("2acee48d-73fd-42f9-97a9-3065f135d683"), "Фрукты" },
                    { new Guid("cec11f6b-1a28-4981-8042-66780bb94c1f"), "Овощи" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: new Guid("2acee48d-73fd-42f9-97a9-3065f135d683"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: new Guid("cec11f6b-1a28-4981-8042-66780bb94c1f"));
        }
    }
}
