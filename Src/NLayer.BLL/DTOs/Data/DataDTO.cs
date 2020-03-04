using NLayer.BLL.DTOs.Base;

namespace NLayer.BLL.DTOs
{
    public class DataDTO : AuditableDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
