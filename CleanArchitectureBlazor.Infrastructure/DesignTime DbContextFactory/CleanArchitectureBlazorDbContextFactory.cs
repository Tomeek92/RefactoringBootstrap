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

            optionsBuilder.UseSqlServer("");

            return new CleanArchitectureBlazorDbContext(optionsBuilder.Options);
        }
    }
}
