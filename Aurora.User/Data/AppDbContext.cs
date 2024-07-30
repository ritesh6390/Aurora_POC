using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using System.Reflection.Emit;
using Aurora.User.Models.User;

namespace Aurora.User.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            for (int i = 1; i <= 100; i++)
            {
                builder.Entity<Users>().HasData(new Users
                {
                    UserId= i,
                    FirstName = "User_"+Convert.ToString(i),
                    LastName = "Aurora",
                    EmailId = "User_" + Convert.ToString(i)+"@gmail.com"
                });
            }
        }
    }
}
