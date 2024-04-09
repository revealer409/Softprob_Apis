using Softprob.Domain.Entities.Common;

namespace Softprob.Domain.Entities
{
    public class Technology : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<Project>? Projects { get; set; }
    }
}
