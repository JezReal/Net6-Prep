using AutoMapper;
using Net6_Prep.CourseNS.dtos;
using Net6_Prep.CourseNS.repositories;
using Net6_Prep.Exceptions;
using Net6_Prep.Models;

namespace Net6_Prep.CourseNS.services;

public class CourseService : ICourseService
{

    private readonly ICourseRepository _courseRepository;
    private readonly IMapper _mapper;

    public CourseService(ICourseRepository courseRepository, IMapper mapper)
    {
        _courseRepository = courseRepository;
        _mapper = mapper;
    }

    public void AddCourse(Course course)
    {
        _courseRepository.AddCourse(course);
    }

    public void DeleteCourse(long id)
    {
        var course = _courseRepository.GetCourseById(id);

        if (course == null)
        {
            throw new ResourceNotFoundException($"Course id {id} not found.");
        }

        _courseRepository.DeleteCourse(id);
    }

    public IEnumerable<Course> GetAllCourses()
    {
        return _courseRepository.GetAllCourses();
    }

    public Course GetCourseById(long id)
    {
        var course = _courseRepository.GetCourseById(id);

        if (course == null)
        {
            throw new ResourceNotFoundException($"Course id {id} not found.");
        }

        return course;
    }

    public void UpdateCourse(long id, Course course)
    {
        var courseModel = _courseRepository.GetCourseById(id);

        if (courseModel == null)
        {
            throw new ResourceNotFoundException($"Course id {id} not found.");
        }

        _courseRepository.UpdateCourse(id, course);
    }
}