using Microsoft.EntityFrameworkCore;
using TwilioClient.Core.Entities;
using TwilioClient.Data.Configurations;

namespace TwilioClient.Data
{
    // Use below commands to create migrations
    // Create Migration - dotnet ef --startup-project <startup-project> migrations add Initial --project <migrations-project>
    // Update Database  - dotnet ef database update --project <startup project>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<RegisteredApp> RegisteredApps { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Apply all entity configurations
            builder
                .ApplyConfigurationsFromAssembly(typeof (
                    RegisteredAppConfiguration
                ).Assembly);
        }
    }
}
