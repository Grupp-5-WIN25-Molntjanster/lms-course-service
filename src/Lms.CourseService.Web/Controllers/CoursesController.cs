using Lms.CourseService.Domain.Entities;
using Lms.CourseService.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lms.CourseService.Application.DTOs;
using Lms.CourseService.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

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

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateCourse(CourseDto dto)
    {
        var course = new Course
        {
            Title = dto.Title,
            Description = dto.Description,
            ImageUrl = dto.ImageUrl,
            Instructor = dto.Instructor,
            LessonsCount = dto.LessonsCount,
            Duration = dto.Duration
        };

        context.Courses.Add(course);
        await context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCourseById), new { id = course.Id }, new CourseDto
        {
            Id = course.Id,
            Title = course.Title,
            Description = course.Description,
            ImageUrl = course.ImageUrl,
            Instructor = course.Instructor,
            LessonsCount = course.LessonsCount,
            Duration = course.Duration
        });
    }

    [Authorize]
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateCourse(int id, CourseDto dto)
    {
        var course = await context.Courses.FindAsync(id);

        if (course is null)
            return NotFound();

        course.Title = dto.Title;
        course.Description = dto.Description;
        course.ImageUrl = dto.ImageUrl;
        course.Instructor = dto.Instructor;
        course.LessonsCount = dto.LessonsCount;
        course.Duration = dto.Duration;

        await context.SaveChangesAsync();

        return NoContent();
    }

    [Authorize]
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCourse(int id)
    {
        var course = await context.Courses.FindAsync(id);

        if (course is null)
            return NotFound();

        context.Courses.Remove(course);
        await context.SaveChangesAsync();

        return NoContent();
    }
}