using Microsoft.EntityFrameworkCore;
using WebAppDemo.Models;

namespace WebAppDemo.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> 
            options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
