using FirstWebsite.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstWebsite.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Estate> Estates { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<City> Citys { get; set; } = null!;

       
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

            builder.Entity<City>()
                .Property(p => p.isPopular)
                .HasDefaultValue(false);

            base.OnModelCreating(builder);
        }
    }
}