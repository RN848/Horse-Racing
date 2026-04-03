using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "staff",
                columns: new[] { "StaffId", "Department", "FullName", "JobTitle" },
                values: new object[] { 1, null, "Rayan Robot-Operator", "Technician" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "staff",
                keyColumn: "StaffId",
                keyValue: 1);
        }
    }
}
