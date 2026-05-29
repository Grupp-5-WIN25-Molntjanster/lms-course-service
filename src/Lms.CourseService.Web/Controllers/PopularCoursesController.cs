using Lms.CourseService.Application.PopularCourses;
using Microsoft.AspNetCore.Mvc;

namespace Lms.CourseService.Web.Controllers;

[ApiController]
[Route("api/popular-courses")]
public class PopularCoursesController : ControllerBase
{
	[HttpGet]
	public ActionResult<IEnumerable<PopularCourseDto>> Get()
	{
		return Ok(new[]
		{
			new PopularCourseDto
			{
				Title = "Graphic Design",
				Subtitle = "Creating Visual Content",
				IconUrl = "/courseImages/graphic-design.svg"
			},
			new PopularCourseDto
			{
				Title = "UI/UX Design",
				Subtitle = "Combines User Interface (UI)",
				IconUrl = "/courseImages/uiux.svg"
			},
			new PopularCourseDto
			{
				Title = "Brand Identity",
				Subtitle = "The Collection of Visual",
				IconUrl = "/courseImages/brand.svg"
			},
			new PopularCourseDto
			{
				Title = "Web Design",
				Subtitle = "Process of Creating Websites",
				IconUrl = "/courseImages/web.svg"
			}
		});
	}
}