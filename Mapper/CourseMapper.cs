using AutoMapper;
using Net6_Prep.CourseNS.dtos;
using Net6_Prep.Models;

namespace Net6_Prep.Mapper;

public class CourseMapper : Profile
{
    public CourseMapper()
    {
        CreateMap<AddUpdateCourseDto, Course>();
        CreateMap<Course, GetCourseWithIdDto>();
        CreateMap<Course, GetCourseDto>();
    }
}