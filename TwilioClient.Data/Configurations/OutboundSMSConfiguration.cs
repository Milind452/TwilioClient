using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwilioClient.Core.Entities;

namespace TwilioClient.Data.Configurations
{
    public class
    OutboundSMSConfiguration
    : IEntityTypeConfiguration<OutboundSMS>
    {
        public void Configure(EntityTypeBuilder<OutboundSMS> builder)
        {
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.HasKey(b => b.Id);
            builder.Property(b => b.AppName).IsRequired().HasMaxLength(100);
            builder.Property(b => b.TwilioSID).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Body).IsRequired();
            builder.Property(b => b.To).IsRequired().HasMaxLength(100);
            builder.Property(b => b.From).IsRequired().HasMaxLength(100);
            builder.Property(b => b.ReceivedUTC).IsRequired();
            builder.Property(b => b.SentUTC);
            builder.Property(b => b.Status).HasConversion<string>();
            builder.Property(b => b.MessageResponse);
            builder
                .Property(b => b.ExternalId)
                .IsRequired()
                .ValueGeneratedOnAdd();
        }
    }
}
