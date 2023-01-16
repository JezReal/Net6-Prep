using Net6_Prep.Models;

namespace Net6_Prep.CourseNS.repositories;

public interface ICourseRepository {
    bool SaveChanges();
    IEnumerable<Course> GetAllCourses();
    Course? GetCourseById(long id);
    void AddCourse(Course course);
    void UpdateCourse(long id, Course course);
    void DeleteCourse(long id); 
}