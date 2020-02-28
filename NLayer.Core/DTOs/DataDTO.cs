using NLayer.Core.Abstractions.DTO;

namespace NLayer.Core.DTOs
{
    public class DataDTO : AuditableDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
