using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using FiberTechHR.Backend.Data;

namespace FiberTechHR.Backend.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=tcp:fibertech-sql-server.database.windows.net,1433;Initial Catalog=FiberTechDB;Persist Security Info=False;User ID=sqladmin;Password=StrongPassword@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
