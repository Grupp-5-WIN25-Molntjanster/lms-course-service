using Lms.CourseService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lms.CourseService.Infrastructure.Data;

public class CourseDbContext(DbContextOptions<CourseDbContext> options)
    : DbContext(options)
{
    public DbSet<Course> Courses => Set<Course>();
}