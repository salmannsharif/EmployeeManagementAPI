using EmpApplication.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmpApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }

}
