
namespace Softprob.Domain.Entities.Common
{
    public abstract class BaseEntity<T> 
    {
        public T? Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
