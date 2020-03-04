using NLayer.Core.Abstractions;
using NLayer.DAL.Entities.Base;

namespace NLayer.DAL.Entities
{
    public class Data : AuditableEntity, IArchivable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set; }
    }
}
