using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lms.CourseService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPopularCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PopularCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopularCourses", x => x.Id);
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PopularCourses");
        }
    }
}
