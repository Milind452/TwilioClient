using Microsoft.EntityFrameworkCore;
using TwilioClient.Core.Entities;
using TwilioClient.Data.Configurations;

namespace TwilioClient.Data
{
    public class AppDbContext : DbContext
    {
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
