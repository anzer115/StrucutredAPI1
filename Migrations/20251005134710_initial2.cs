using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StrucutredAPI1.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "C_id", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 1, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "C_id", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "C_id", "StudentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "C_id", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "C_id", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "C_id", "StudentId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "C_id", "StudentId" },
                keyValues: new object[] { 5, 5 });
        }
    }
}
