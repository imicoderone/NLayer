using NLayer.Core.Abstractions;
using NLayer.Core.Abstractions.Entity;

namespace NLayer.Core.Entities
{
    public class Data : AuditableEntity, IArchivable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set; }
    }
}
