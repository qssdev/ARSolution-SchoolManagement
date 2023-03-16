using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Data
{
    public class SchoolAppDbContext : DbContext
    {

        public SchoolAppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }

        public DbSet<People> People { get; set; }
        public DbSet<SubjectClass> Classes { get; set; }
        public DbSet<ProfessorClass> ProfessorClasses { get; set; }
    }
}
