using System.Data.Entity;

namespace StudentApp
{
    // This class inherits from DbContext and represents the session with the database
    public class StudentContext : DbContext
    {
        // Constructor specifies the name of the connection string
        public StudentContext() : base("StudentDb")
        {
        }

        // This DbSet represents the Students table in the database
        public DbSet<Student> Students { get; set; }
    }
}
