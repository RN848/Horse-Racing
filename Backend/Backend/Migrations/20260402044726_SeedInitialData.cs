using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "RoomId", "Description" },
                values: new object[,]
                {
                    { "A-101", "Emergency Room" },
                    { "LAB-05", "Pathology Lab" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "RoomId",
                keyValue: "A-101");

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "RoomId",
                keyValue: "LAB-05");
        }
    }
}
