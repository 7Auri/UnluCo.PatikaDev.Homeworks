using CodeFirst_patika_dev.Entity;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_patika_dev
{

    public class PatikaDBContext : DbContext
    {
        public PatikaDBContext(DbContextOptions<PatikaDBContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Success> Successz { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Partipant> Partipants { get; set; }


    }
}
