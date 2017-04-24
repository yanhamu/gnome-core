using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gnome.DataAccess
{
    public class GnomeDbContext : IdentityDbContext<ApplicationUser>
    {
        public GnomeDbContext() { }
        public GnomeDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Account>().HasKey(p => p.Id);
            builder.Entity<Account>().Property(p => p.Id).ValueGeneratedNever();

            base.OnModelCreating(builder);
        }

        public DbSet<Account> Accounts { get; set; }
    }
}