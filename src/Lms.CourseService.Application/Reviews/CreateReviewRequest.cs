namespace Lms.CourseService.Application.Reviews;

public class CreateReviewRequest
{
    public int CourseId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
}