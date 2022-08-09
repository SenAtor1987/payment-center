using payment_center_3.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace payment_center_3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
    }
}