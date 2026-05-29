namespace Lms.CourseService.Application.Reviews;

public class ReviewResponse
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public int UserId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
}