using Net6_Prep.Data;
using Net6_Prep.Models;

namespace Net6_Prep.CourseNS.repositories;

public class CourseRepository : ICourseRepository {

    private readonly CourseDatabase _courseDatabase;
    
    public CourseRepository(CourseDatabase courseDatabase) {
        _courseDatabase = courseDatabase;
    }

    public void AddCourse(Course course)
    {
        Console.WriteLine($"Course: {course.CourseName}");
        _courseDatabase.Add(course);
        _courseDatabase.SaveChanges();
    }

    public void DeleteCourse(long id)
    {
        var courseToDelete = _courseDatabase.Courses.Single(course => course.CourseId == id);
        _courseDatabase.Remove(courseToDelete);
        _courseDatabase.SaveChanges();
    }

    public IEnumerable<Course> GetAllCourses()
    {
        return _courseDatabase.Courses.ToList();
    }

    public Course? GetCourseById(long id)
    {
        return _courseDatabase.Courses.SingleOrDefault(course => course.CourseId == id);
    }

    public bool SaveChanges()
    {
        return _courseDatabase.SaveChanges() >= 0;
    }

    public void UpdateCourse(long id, Course course)
    {
        var courseToUpdate = _courseDatabase.Courses.Single(course => course.CourseId == id);

        courseToUpdate.CourseName = course.CourseName;

        _courseDatabase.Update(courseToUpdate);
        _courseDatabase.SaveChanges();
    }
}