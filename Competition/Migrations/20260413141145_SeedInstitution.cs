using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Competition.Migrations
{
    /// <inheritdoc />
    public partial class SeedInstitution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "City", "Name" },
                values: new object[,]
                {
                    { 1, "Звягель", "ДЮКФП міста Звягеля" },
                    { 2, "Олевськ", "Олевська дитячо-юнацька спортивна школа" },
                    { 3, "Баранівка", "Баранівська районна дитячо-юнацька спортивна школа" },
                    { 4, "Андрушівка", "Андрушівська ДЮСШ" },
                    { 5, "Бердичів", "Бердичівська дитячо-юнацька спортивна школа ім. В.О. Лонського" },
                    { 6, "Житомир", "Дитячо-юнацька спортивна школа ЖМР" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
