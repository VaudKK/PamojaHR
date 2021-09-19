using CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM.Context
{
    public class PostgreContext : DbContext
    {

        public PostgreContext(DbContextOptions<PostgreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Value Converters
            builder
                .Entity<Organization>()
                .Property(e => e.OrganizationId)
                .HasConversion<string>();
        }

        public DbSet<Organization> Organizations { get; set; }
    }
}