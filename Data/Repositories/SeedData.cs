using payment_center_3.Models;
using payment_center_3.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace payment_center_3.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());
            // Look for any movies.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var admin = new User
            {
                Login = "admin",
                Password = "admin",
                Role = "Admin",
            };
            var user = new User
            {
                Login = "user",
                Password = "user",
                Role = "User",
            };

            context.Users.Add(admin);
            context.Users.Add(user);

            await context.SaveChangesAsync();
        }
    }
}