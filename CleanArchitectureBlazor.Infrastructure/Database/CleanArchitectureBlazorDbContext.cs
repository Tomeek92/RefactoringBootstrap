using CleanArchitectureBlazor.Domain.Admin;
using CleanArchitectureBlazor.Domain.NewsLetterEmails;
using CleanArchitectureBlazor.Domain.Price_Training;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitectureBlazor.Infrastructure.Database
{
    public class CleanArchitectureBlazorDbContext : DbContext
    {
        public CleanArchitectureBlazorDbContext(DbContextOptions<CleanArchitectureBlazorDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<NewsLetterEmail> NewsLetterEmails { get; set; }
        public DbSet<PriceTrain> PricesTrain { get; set; }
        public DbSet<Train> Trains { get; set; }      
    }
}
