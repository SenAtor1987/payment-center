using payment_center_3.Data;
using payment_center_3.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace payment_center_3.Data.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> GetAsync(string login) => await _dbContext.Users.FirstOrDefaultAsync(x => x.Login.ToLower() == login.ToLower());
    }
}