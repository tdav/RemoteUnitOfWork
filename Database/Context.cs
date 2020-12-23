using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Database
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local)\AptekaSQL;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
