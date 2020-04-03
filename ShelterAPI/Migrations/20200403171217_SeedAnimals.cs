using Microsoft.EntityFrameworkCore.Migrations;

namespace ShelterAPI.Migrations
{
    public partial class SeedAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 3, "Bobtail", "Male", "Bert", "Cat" },
                    { 2, 8, "Siamese", "Female", "Alice", "Cat" },
                    { 3, 1, "Shorthair", "Male", "Alfred", "Cat" },
                    { 4, 4, "Maine Coon", "Female", "Margo", "Cat" },
                    { 5, 12, "Dachsund", "Male", "Andrew", "Dog" },
                    { 6, 6, "Mixed", "Male", "Eduardo", "Dog" },
                    { 7, 4, "Shih Tzu", "Female", "Angela", "Dog" },
                    { 8, 10, "Dalmation", "Male", "Bingo", "Dog" }
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
        }
    }
}
