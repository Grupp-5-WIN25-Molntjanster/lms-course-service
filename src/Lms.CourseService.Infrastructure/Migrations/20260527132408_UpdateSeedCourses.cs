using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lms.CourseService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Duration", "ImageUrl", "Instructor", "LessonsCount", "Title" },
                values: new object[] { "Artificial Intelligence course", "3 hr 45 min", "/ai-small.svg", "Alice Johnson", 10, "Artificial Intelligence" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Duration", "ImageUrl", "Instructor", "LessonsCount", "Title" },
                values: new object[] { "Data Science & Analytics course", "1 hr 50 min", "/data-science-small.svg", "Bob Brown", 6, "Data Science & Analytics" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Instructor", "LessonsCount", "Title" },
                values: new object[,]
                {
                    { 3, "Learn digital marketing fundamentals", "1 hr 16 min", "/digital-marketing-small.svg", "John Doe", 5, "Digital Marketing" },
                    { 4, "Introduction to UI/UX design", "2 hr 30 min", "/ui-ux-small.svg", "Jane Smith", 8, "UI/UX Design" },
                    { 5, "Learn full stack development", "2 hr 20 min", "/full-stack-small.svg", "Charlie Davis", 7, "Full stack Developer " },
                    { 6, "Introduction to sketching for designers", "3 hr 10 min", "/sketch-small.svg", "Diana Evans", 9, "Sketch for Designer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Duration", "ImageUrl", "Instructor", "LessonsCount", "Title" },
                values: new object[] { "Learn digital marketing fundamentals", "1 hr 16 min", "/Digital-Marketing-Small.svg", "John Doe", 5, "Digital Marketing" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Duration", "ImageUrl", "Instructor", "LessonsCount", "Title" },
                values: new object[] { "Introduction to UI/UX design", "2 hr 30 min", "/UI-UX-Small.svg", "Jane Smith", 8, "UI/UX Design" });
        }
    }
}
