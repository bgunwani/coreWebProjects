using Microsoft.EntityFrameworkCore;

namespace coreEFDependencyMiddlewareApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }



    }
}
