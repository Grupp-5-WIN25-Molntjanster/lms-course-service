using Lms.CourseService.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lms.CourseService.Web.Controllers;

[ApiController]
[Route("api/courses")]
public class CoursesController(CourseDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        var courses = await context.Courses.ToListAsync();

        return Ok(courses);
    }
}