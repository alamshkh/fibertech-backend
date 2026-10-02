using Microsoft.EntityFrameworkCore;
using FiberTechHR.Backend.Models;

namespace FiberTechHR.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Employee> Employees { get; set; }
    }
}