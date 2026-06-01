using Lms.CourseService.Application.PopularCourses;
using Lms.CourseService.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lms.CourseService.Web.Controllers;

[ApiController]
[Route("api/popular-courses")]
public class PopularCoursesController(CourseDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PopularCourseDto>>> Get()
    {
        var popularCourses = await context.Courses
            .Select(course => new
            {
                Course = course,
                AverageRating = context.Reviews
                    .Where(review => review.CourseId == course.Id)
                    .Average(review => (double?)review.Rating) ?? 0,
                ReviewCount = context.Reviews
                    .Count(review => review.CourseId == course.Id)
            })
            .OrderByDescending(x => x.AverageRating)
            .ThenByDescending(x => x.ReviewCount)
            .Take(4)
            .Select(x => new PopularCourseDto
            {
                Title = x.Course.Title,
                Subtitle = x.Course.Instructor,
                IconUrl = x.Course.ImageUrl
            })
            .ToListAsync();

        return Ok(popularCourses);
    }
}