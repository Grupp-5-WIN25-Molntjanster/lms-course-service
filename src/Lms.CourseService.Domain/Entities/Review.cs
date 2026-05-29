using System.ComponentModel.DataAnnotations;

namespace Lms.CourseService.Domain.Entities;

public class Review
{
    public int Id { get; set; }

    [Required]
    public int CourseId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }

    [MaxLength(500)]
    public string Comment { get; set; } = string.Empty;

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}