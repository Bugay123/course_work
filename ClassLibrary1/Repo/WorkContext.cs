using CourseWorkLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace CourseWorkLibrary.Repo
{
    public class WorkContext : DbContext
    {
        public DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=workDb;Username=postgres;Password=postgres");
        }
    }
}
