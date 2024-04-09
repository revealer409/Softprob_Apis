using Softprob.Domain.Entities.Common;

namespace Softprob.Domain.Entities
{
    public class ProjectTool:BaseEntity<int>
    {
        public string Version { get; set; }=string.Empty;       
        public int ProjectId { get; set; }
        public int ToolId { get; set; }
        public Project Project { get; set; }
         
    }
}
