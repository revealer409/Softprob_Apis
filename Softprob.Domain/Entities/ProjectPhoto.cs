using Softprob.Domain.Entities.Common;

namespace Softprob.Domain.Entities
{
    public class ProjectPhoto: BaseEntity<int>
    {
        public string Image { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool IsCover { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }


    }
}
