using Microsoft.EntityFrameworkCore;
using TwilioClient.Core.Entities;
using TwilioClient.Data.Configurations;

namespace TwilioClient.Data
{
    // Use below commands to create migrations
    // Create Migration - dotnet ef --startup-project <startup-project> migrations add <migration-name> --project <migrations-project>
    // Update Database  - dotnet ef database update --project <startup project>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<RegisteredApp> RegisteredApps { get; set; }

        public DbSet<OutboundSMS> OutboundSMSs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Apply all entity configurations
            builder
                .ApplyConfigurationsFromAssembly(typeof (
                    RegisteredAppConfiguration
                ).Assembly);

            // Set table name to entity name
            foreach (var entity in builder.Model.GetEntityTypes())
            {
                builder.Entity(entity.Name).ToTable(entity.DisplayName());
            }
        }
    }
}
