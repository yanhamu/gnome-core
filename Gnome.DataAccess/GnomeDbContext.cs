using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gnome.DataAccess
{
    public class GnomeDbContext : IdentityDbContext<ApplicationUser>
    {
        public GnomeDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Map<Account>(builder);
            Map<Transaction>(builder);

            base.OnModelCreating(builder);
        }

        private void Map<T>(ModelBuilder builder)
            where T : class, IEntity<T>, new()
        {
            new T().Map(builder.Entity<T>());
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}