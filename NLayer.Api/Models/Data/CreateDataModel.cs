using NLayer.Api.Models.Base;

namespace NLayer.Api.Models
{
    public class CreateDataModel : Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
