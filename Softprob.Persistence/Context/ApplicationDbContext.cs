using Microsoft.EntityFrameworkCore;
using Softprob.Domain.Entities; 

namespace Softprob.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        DbSet<TeamPlayer> TeamPlayers { get; set; }
        DbSet<Designation> Desigations { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<ProjectPhoto> ProjectPhotos { get; set; }
        DbSet<ProjectTechnology> ProjectTechnologies { get; set; }
        DbSet<ProjectTool> ProjectTools { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {                        
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure BaseEntity
            //modelBuilder.Entity<BaseEntity<int>>();

            //// Configure BaseAuditableEntity
            //modelBuilder.Entity<BaseAuditableEntity<int>>();
        }

       
    }
}
 