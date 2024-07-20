using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Api.Models;

namespace RepositoryPatternDemo.Api.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
            
        }

        public DbSet<MyEmployee> Employees { get; set; }
    }
}
