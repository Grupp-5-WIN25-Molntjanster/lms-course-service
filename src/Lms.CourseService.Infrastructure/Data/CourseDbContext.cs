using Lms.CourseService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lms.CourseService.Infrastructure.Data;

public class CourseDbContext(DbContextOptions<CourseDbContext> options)
    : DbContext(options)
{
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Review> Reviews => Set<Review>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                Title = "Artificial Intelligence",
                Description = "Artificial Intelligence course",
                ImageUrl = "/ai-small.svg",
                Instructor = "Alice Johnson",
                LessonsCount = 10,
                Duration = "3 hr 45 min"
            },
            new Course
            {
                Id = 2,
                Title = "Data Science & Analytics",
                Description = "Data Science & Analytics course",
                ImageUrl = "/data-science-small.svg",
                Instructor = "Bob Brown",
                LessonsCount = 6,
                Duration = "1 hr 50 min"
            },
            new Course
            {
                Id = 3,
                Title = "Digital Marketing",
                Description = "Learn digital marketing fundamentals",
                ImageUrl = "/digital-marketing-small.svg",
                Instructor = "John Doe",
                LessonsCount = 5,
                Duration = "1 hr 16 min"
            },
            new Course
            {
                Id = 4,
                Title = "UI/UX Design",
                Description = "Introduction to UI/UX design",
                ImageUrl = "/ui-ux-small.svg",
                Instructor = "Jane Smith",
                LessonsCount = 8,
                Duration = "2 hr 30 min"
            },
            new Course
            {
                Id = 5,
                Title = "Full stack Developer ",
                Description = "Learn full stack development",
                ImageUrl = "/full-stack-small.svg",
                Instructor = "Charlie Davis",
                LessonsCount = 7,
                Duration = "2 hr 20 min"
            },
            new Course
            {
                Id = 6,
                Title = "Sketch for Designer",
                Description = "Introduction to sketching for designers",
                ImageUrl = "/sketch-small.svg",
                Instructor = "Diana Evans",
                LessonsCount = 9,
                Duration = "3 hr 10 min"
            }
        );
    }
}

