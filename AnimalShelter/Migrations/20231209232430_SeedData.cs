using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Color", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 2, "Black & Tan", "Beethoven", "Dog" },
                    { 2, 3, "Orange", "Garfield", "Cat" },
                    { 3, 4, "Tan", "Marley", "Dog" },
                    { 4, 1, "Brindle", "Fido", "Dog" },
                    { 5, 4, "Grey", "Smokey", "Cat" },
                    { 6, 1, "Black", "Cujo", "Dog" },
                    { 7, 2, "Calico", "Cali", "Cat" },
                    { 8, 6, "Golden", "Bud", "Dog" },
                    { 9, 1, "Red", "Clifford", "Dog" },
                    { 10, 4, "Tuxedo", "Tom", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);
        }
    }
}
