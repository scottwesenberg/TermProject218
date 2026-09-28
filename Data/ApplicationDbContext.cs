using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllGamesGameReviews.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Identity already makes usernames unique in the database.
            // Make emails unique in the database too, so two accounts can never share one,
            // even if two sign-ups happen at the exact same moment.
            builder.Entity<IdentityUser>()
                .HasIndex(u => u.NormalizedEmail)
                .IsUnique()
                .HasDatabaseName("UniqueEmailIndex")
                .HasFilter("[NormalizedEmail] IS NOT NULL");
        }
    }
}
