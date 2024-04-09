using Softprob.Domain.Entities.Common;

namespace Softprob.Domain.Entities
{
    public class Designation : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<TeamPlayer>? TeamPlayers { get; set; }
    }
}
