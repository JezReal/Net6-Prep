using Net6_Prep.CourseNS.dtos;
using Net6_Prep.Models;

namespace Net6_Prep.CourseNS.services;

public interface ICourseService {
    IEnumerable<Course> GetAllCourses();
    Course? GetCourseById(long id);
    void AddCourse(Course course);
    void UpdateCourse(long id, Course course);
    void DeleteCourse(long id); 
}