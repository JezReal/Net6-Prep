using System.ComponentModel.DataAnnotations;

namespace Net6_Prep.Models;

public class Course
{   
    [Key]
    [Required]
    public long CourseId { get; set; }

    [Required]
    public string CourseName { get; set; } = string.Empty;
}