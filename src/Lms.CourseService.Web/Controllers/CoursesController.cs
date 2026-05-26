using Lms.CourseService.Domain.Entities;
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

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCourseById(int id)
    {
        var course = await context.Courses
            .FirstOrDefaultAsync(x => x.Id == id);

        if (course is null)
            return NotFound();

        return Ok(course);
    }
}