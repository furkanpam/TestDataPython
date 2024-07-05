using Vanguard.Abstraction.Domain;
using System.ComponentModel.DataAnnotations;

namespace Vanguard.Core.Domain.Entity
{
    public abstract class BaseEntity<TKey> : CardEntity
    {
        [Key]
        public TKey Id { get; set; }

        public BaseEntity()
        {
            if (typeof(TKey) == typeof(string))
            {
                Id = (TKey)(object)Guid.NewGuid().ToString();
            }
            else if (typeof(TKey) == typeof(Guid))
            {
                Id = (TKey)(object)Guid.NewGuid();
            }
        }
    }
}
