using CleanArchitectureBlazor.Infrastructure.Database;

namespace CleanArchitectureBlazor.Infrastructure.Repository
{
    public class AccountRepository
    {
        private readonly CleanArchitectureBlazorDbContext _context;
        
        public AccountRepository(CleanArchitectureBlazorDbContext context)
        {
            _context = context;
        }
       // public async Task<Account> Login(string UserName , string);
       //public async Task Logout() await _signinmanager.SignOutAsync();
       //public async Task<Account> Register();

    }
}
