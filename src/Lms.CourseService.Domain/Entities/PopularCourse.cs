namespace Lms.CourseService.Domain.Entities;

public class PopularCourse
{
	public int Id { get; set; }

	public string Title { get; set; } = null!;

	public string Subtitle { get; set; } = null!;

	public string IconUrl { get; set; } = null!;
}