using Microsoft.EntityFrameworkCore;
using TestServer.Service;

namespace TestServer
{
    public class SchoolDataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public SchoolDataContext(DbContextOptions<SchoolDataContext> options)
            : base(options)
        {

            Database.EnsureCreated();
        }
    }
}
