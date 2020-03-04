using System;

namespace NLayer.Core.Abstractions.DTO
{
    public class AuditableDTO : DTO, IAuditable
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Version { get; set; }
    }
}
