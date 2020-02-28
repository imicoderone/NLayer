using System;

namespace NLayer.Core.Abstractions.Entity
{
    public class AuditableEntity : Entity, IAuditable
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Version { get; set; }
    }
}
