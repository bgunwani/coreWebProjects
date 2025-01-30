using Microsoft.EntityFrameworkCore;

namespace coreEFDependencyMiddlewareApp.Models
{
    public class ApplicationDbContext: DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-Q8KMI7N;Database=SampleDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}
