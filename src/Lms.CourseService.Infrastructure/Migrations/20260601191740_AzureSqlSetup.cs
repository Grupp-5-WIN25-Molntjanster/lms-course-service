using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lms.CourseService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AzureSqlSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "PopularCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PopularCourses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PopularCourses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PopularCourses",
                keyColumn: "Id",
                keyValue: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Instructor", "LessonsCount", "Title" },
                values: new object[,]
                {
                    { 1, "Artificial Intelligence course", "3 hr 45 min", "/ai-small.svg", "Alice Johnson", 10, "Artificial Intelligence" },
                    { 2, "Data Science & Analytics course", "1 hr 50 min", "/data-science-small.svg", "Bob Brown", 6, "Data Science & Analytics" },
                    { 3, "Learn digital marketing fundamentals", "1 hr 16 min", "/digital-marketing-small.svg", "John Doe", 5, "Digital Marketing" },
                    { 4, "Introduction to UI/UX design", "2 hr 30 min", "/ui-ux-small.svg", "Jane Smith", 8, "UI/UX Design" },
                    { 5, "Learn full stack development", "2 hr 20 min", "/full-stack-small.svg", "Charlie Davis", 7, "Full stack Developer " },
                    { 6, "Introduction to sketching for designers", "3 hr 10 min", "/sketch-small.svg", "Diana Evans", 9, "Sketch for Designer" }
                });

            migrationBuilder.InsertData(
                table: "PopularCourses",
                columns: new[] { "Id", "IconUrl", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, "/courseImages/graphic-d-icon.svg", "Creating Visual Content", "Graphic Design" },
                    { 2, "/courseImages/uiux-d-icon.svg", "Combines User Interface (UI)", "UI/UX Design" },
                    { 3, "/courseImages/brand-i-icon.svg", "The Collection of Visual", "Brand Identity" },
                    { 4, "/courseImages/web-d-icon.svg", "Process of Creating Websites", "Web Design" }
                });
        }
    }
}
