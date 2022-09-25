using FirstWebsite.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstWebsite.Ui.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        DbSet<Estate> Estates { get; set; } = null!;
        DbSet<Address> Addresses { get; set; } = null!;
        DbSet<Country> Countries { get; set; } = null!;
        DbSet<City> Citys { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Estate>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            builder.Entity<Address>()
               .Property(p => p.IsDeleted)
               .HasDefaultValue(false);

            builder.Entity<Country>()
               .Property(p => p.IsDeleted)
               .HasDefaultValue(false);

            builder.Entity<City>()
               .Property(p => p.IsDeleted)
               .HasDefaultValue(false);

            base.OnModelCreating(builder);
        }
    }
}