namespace Lms.CourseService.Application.DTOs;

public class CourseDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string Instructor { get; set; } = null!;

    public int LessonsCount { get; set; }

    public string Duration { get; set; } = null!;
}