
using System.Runtime.InteropServices;

namespace Softprob.Domain.Entities.Common
{
    public abstract class BaseAuditableEntity<T>
    {
        public T? Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } =string.Empty;
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } =string.Empty;
        public bool IsDeleted { get; set; }  
    }
 
}
