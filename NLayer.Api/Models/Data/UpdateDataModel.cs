using NLayer.Api.Models.Base;

namespace NLayer.Api.Models
{
    public class UpdateDataModel : Model
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
