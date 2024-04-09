using Softprob.Domain.Entities.Common;

namespace Softprob.Domain.Entities
{
    public class ProjectTechnology:BaseEntity<int>
    {
        public string Version { get; set; }=string.Empty;       
        public int ProjectId { get; set; }
        public int TechnologyId { get; set; }
        public Project? Project { get; set; }
    }
}
