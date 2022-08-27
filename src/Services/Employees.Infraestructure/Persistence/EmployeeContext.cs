using Employees.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employees.Infraestructure.Persistence
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) 
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
