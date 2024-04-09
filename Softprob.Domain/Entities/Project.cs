using Softprob.Domain.Entities.Common;

namespace Softprob.Domain.Entities
{
    public class Project: BaseAuditableEntity<int>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<ProjectPhoto>? ProjectPhotos { get; set; }
        public virtual ICollection<ProjectTechnology>? ProjectTechnologies { get; set; }
        public virtual ICollection<ProjectTool>? ProjectTools { get; set; }

    }
}


