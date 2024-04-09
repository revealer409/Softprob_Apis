// TeamPlayerConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softprob.Domain.Entities;

namespace Softprob.Persistence.Configurations
{
    public class TeamPlayerConfiguration : IEntityTypeConfiguration<TeamPlayer>
    {
        public void Configure(EntityTypeBuilder<TeamPlayer> builder)
        {
            builder.ToTable("TeamPlayers");  

            builder.HasKey(tp => tp.Id);            
            // Configure other entity properties
            builder.Property(tp => tp.FirstName).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(tp => tp.LastName).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(tp => tp.Pid).IsRequired().HasDefaultValue(0);
            builder.Property(tp => tp.IsDeleted).HasDefaultValue(false);

            // Configure self-referencing foreign key
            builder.HasOne(tp => tp.Designation)
                   .WithMany()
                   .HasForeignKey(tp => tp.DesignationId)
                   .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(tp => tp.Designation)
                   .WithMany(d => d.TeamPlayers)
                   .HasForeignKey(tp => tp.DesignationId)
                   .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
