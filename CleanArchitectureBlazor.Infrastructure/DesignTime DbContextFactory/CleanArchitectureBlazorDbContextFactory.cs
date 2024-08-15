using CleanArchitectureBlazor.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitectureBlazor.Infrastructure.DesignTime_DbContextFactory
{
    public class CleanArchitectureBlazorDbContextFactory : IDesignTimeDbContextFactory<CleanArchitectureBlazorDbContext>
    {
        public CleanArchitectureBlazorDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CleanArchitectureBlazorDbContext>();

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JD2U15O\\MSSQLSERVER02;Database=BlazorCleanArchitecture;Integrated Security=True;TrustServerCertificate=True;");

            return new CleanArchitectureBlazorDbContext(optionsBuilder.Options);
        }
    }
}
