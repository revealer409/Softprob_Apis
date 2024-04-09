using Softprob.Domain.Entities.Common; 

namespace Softprob.Domain.Entities
{
    public class TeamPlayer : BaseAuditableEntity<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Pid { get; set; } = 0;
        public int DesignationId { get; set; }
        public ICollection<TeamPlayer>? Subordinates { get; set; }
        public Designation? Designation { get; }
    }
}


 