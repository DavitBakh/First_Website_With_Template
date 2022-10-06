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
        public DbSet<OwnerContactInfo> OwnerContacts { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Estate>()
                .HasQueryFilter(e => !e.IsDeleted)
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            builder.Entity<Address>()
               .HasQueryFilter(e => !e.IsDeleted)
               .Property(p => p.IsDeleted)
               .HasDefaultValue(false);

            builder.Entity<Country>()
                .HasQueryFilter(e => !e.IsDeleted)
               .Property(p => p.IsDeleted)
               .HasDefaultValue(false);

            builder.Entity<City>()
                .HasQueryFilter(e => !e.IsDeleted)
               .Property(p => p.IsDeleted)
               .HasDefaultValue(false);

            builder.Entity<City>()
                .HasQueryFilter(e => !e.IsDeleted)
                .Property(p => p.isPopular)
                .HasDefaultValue(false);

            builder.Entity<OwnerContactInfo>()
                .HasQueryFilter(e => !e.IsDeleted)
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            base.OnModelCreating(builder);
        }
    }
}