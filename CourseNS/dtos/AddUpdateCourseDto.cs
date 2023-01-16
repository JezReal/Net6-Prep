using System.ComponentModel.DataAnnotations;

namespace Net6_Prep.CourseNS.dtos;

public class AddUpdateCourseDto {
    [Required]
    [MinLength(10)]
    public string CourseName {get; set;} = string.Empty;
}