using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lms.CourseService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Instructor", "LessonsCount", "Title" },
                values: new object[,]
                {
                    { 1, "Learn digital marketing fundamentals", "1 hr 16 min", "https://example.com/image1.jpg", "John Doe", 5, "Digital Marketing" },
                    { 2, "Introduction to UI/UX design", "2 hr 30 min", "https://example.com/image2.jpg", "Jane Smith", 8, "UI/UX Design" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
