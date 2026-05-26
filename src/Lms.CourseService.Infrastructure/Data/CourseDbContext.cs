using Lms.CourseService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lms.CourseService.Infrastructure.Data;

public class CourseDbContext(DbContextOptions<CourseDbContext> options)
    : DbContext(options)
{
    public DbSet<Course> Courses => Set<Course>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                Title = "Digital Marketing",
                Description = "Learn digital marketing fundamentals",
                ImageUrl = "https://example.com/image1.jpg",
                Instructor = "John Doe",
                LessonsCount = 5,
                Duration = "1 hr 16 min"
            },
            new Course
            {
                Id = 2,
                Title = "UI/UX Design",
                Description = "Introduction to UI/UX design",
                ImageUrl = "https://example.com/image2.jpg",
                Instructor = "Jane Smith",
                LessonsCount = 8,
                Duration = "2 hr 30 min"
            }
        );
    }
}

