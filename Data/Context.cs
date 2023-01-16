using Microsoft.EntityFrameworkCore;
using Net6_Prep.Models;

namespace Net6_Prep.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {

    }

    public DbSet<Course> Courses { get; set; }

}