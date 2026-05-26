using Lms.CourseService.Domain.Entities;
using Lms.CourseService.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lms.CourseService.Application.DTOs;

namespace Lms.CourseService.Web.Controllers;

[ApiController]
[Route("api/courses")]
public class CoursesController(CourseDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        var courses = await context.Courses
            .Select(x => new CourseDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Instructor = x.Instructor,
                LessonsCount = x.LessonsCount,
                Duration = x.Duration
            })
            .ToListAsync();

        return Ok(courses);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCourseById(int id)
    {
        var course = await context.Courses
            .Where(x => x.Id == id)
            .Select(x => new CourseDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Instructor = x.Instructor,
                LessonsCount = x.LessonsCount,
                Duration = x.Duration
            })
            .FirstOrDefaultAsync();

        if (course is null)
            return NotFound();

        return Ok(course);
    }
}