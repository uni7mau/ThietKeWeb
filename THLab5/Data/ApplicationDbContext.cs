using Microsoft.EntityFrameworkCore;
using THLab5.Models;

namespace THLab5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
            {
            }

        public DbSet<Employee> Employees { get; set; }
    }
}
