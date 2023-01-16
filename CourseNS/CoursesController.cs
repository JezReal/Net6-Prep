using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Net6_Prep.CourseNS.dtos;
using Net6_Prep.CourseNS.services;
using Net6_Prep.Models;

namespace Net6_Prep.CourseNS;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly ICourseService _courseService;
    private readonly IMapper _mapper;

    public CoursesController(ICourseService courseService, IMapper mapper)
    {
        _courseService = courseService;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<GetCourseWithIdDto>> GetAllCourses()
    {
        var courses = _courseService.GetAllCourses();

        return Ok(_mapper.Map<IEnumerable<GetCourseWithIdDto>>(courses));
    }

    [HttpGet("{courseId}")]
    public ActionResult<GetCourseDto> GetCourseById(long courseId)
    {
        var course = _courseService.GetCourseById(courseId);

        if (course == null)
        {
            return NotFound(new { Message = "Course not found" });
        }

        return Ok(_mapper.Map<GetCourseDto>(course));
    }

    [HttpPost]
    public ActionResult AddCourse(AddUpdateCourseDto addCourseDto)
    {
        var courseModel = _mapper.Map<Course>(addCourseDto);

        _courseService.AddCourse(courseModel);
        return Ok();
    }

    [HttpPut]
    public ActionResult UpdateCourse(long courseId, AddUpdateCourseDto updateCourseDto)
    {
        var courseModel = _mapper.Map<Course>(updateCourseDto);

        _courseService.UpdateCourse(courseId, courseModel);
        return Ok();
    }

    [HttpDelete("{courseId}")]
    public ActionResult DeleteCourse(long courseId)
    {
        _courseService.DeleteCourse(courseId);
        return Ok();
    }
}