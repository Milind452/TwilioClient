using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwilioClient.Core.Entities;

namespace TwilioClient.Data.Configurations
{
    public class
    RegisteredAppConfiguration
    : IEntityTypeConfiguration<RegisteredApp>
    {
        public void Configure(EntityTypeBuilder<RegisteredApp> builder)
        {
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.HasKey(b => b.Id);
            builder.Property(b => b.AppName).IsRequired().HasMaxLength(100);
            builder.Property(b => b.AppToken).IsRequired().HasMaxLength(100);
            builder.Property(b => b.TwilioSID).IsRequired().HasMaxLength(100);
            builder.Property(b => b.TwilioToken).IsRequired().HasMaxLength(100);
        }
    }
}
