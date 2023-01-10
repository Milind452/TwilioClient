using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
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
            builder.Property(b => b.TwilioToken).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Body).IsRequired();
            builder.Property(b => b.To).IsRequired().HasMaxLength(100);
            builder.Property(b => b.From).IsRequired().HasMaxLength(100);
            builder
                .Property(b => b.ReceivedUTC)
                .IsRequired()
                .HasDefaultValueSql("getutcdate()");
            builder.Property(b => b.SentUTC);
            builder
                .Property(b => b.Status)
                .HasConversion<string>()
                .HasMaxLength(100);
            builder.Property(b => b.MessageResponse);
            builder.Property(b => b.MessageSID);
            builder
                .Property(b => b.ExternalId)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }
    }
}
