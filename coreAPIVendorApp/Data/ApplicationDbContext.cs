using coreAPIVendorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace coreAPIVendorApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
