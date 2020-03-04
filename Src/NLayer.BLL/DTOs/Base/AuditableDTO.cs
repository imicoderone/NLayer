using NLayer.Core.Abstractions;
using System;

namespace NLayer.BLL.DTOs.Base
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
