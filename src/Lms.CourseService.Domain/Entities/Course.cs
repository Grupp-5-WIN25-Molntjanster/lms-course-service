namespace Lms.CourseService.Domain.Entities;

public class Course
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string Instructor { get; set; } = null!;

    public int LessonsCount { get; set; }

    public string Duration { get; set; } = null!;
}