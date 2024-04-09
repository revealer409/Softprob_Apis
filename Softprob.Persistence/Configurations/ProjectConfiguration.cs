using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softprob.Domain.Entities;
using System.Reflection.Emit;

namespace Softprob.Persistence.Configurations
{
    internal sealed class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            // Configure Project entity here
            builder.ToTable("Projects");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CreateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(p => p.Title).HasColumnType("nvarchar(255)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(p=>p.IsDeleted).HasDefaultValue(false);

            builder.HasQueryFilter(t => !t.IsDeleted);

            // Relationships
            builder.HasMany(p => p.ProjectPhotos)
                   .WithOne(pp => pp.Project)
                   .HasForeignKey(pp => pp.ProjectId)
                   .OnDelete(DeleteBehavior.NoAction);
            //.OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.ProjectTechnologies)
                   .WithOne(pt => pt.Project)
                   .HasForeignKey(pt => pt.ProjectId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.ProjectTools)
                   .WithOne(pt => pt.Project)
                   .HasForeignKey(pt => pt.ProjectId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
