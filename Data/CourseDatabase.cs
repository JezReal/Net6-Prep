using Microsoft.EntityFrameworkCore;
using Net6_Prep.Models;

namespace Net6_Prep.Data;

public class CourseDatabase : DbContext
{
    public CourseDatabase(DbContextOptions<CourseDatabase> options) : base(options)
    {

    }

    public DbSet<Course> Courses {get; set;}

}