
using Microsoft.EntityFrameworkCore;

public class EMSContext: DbContext
{
    public EMSContext(DbContextOptions<EMSContext> options) : base(options)
    {        
    }

    public DbSet<Person> People { get; set; }
    public DbSet<Department> Departments { get; set; }
}
