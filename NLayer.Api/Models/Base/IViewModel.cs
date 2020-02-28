namespace NLayer.Api.Models.Base
{
    public interface IViewModel<TKey> : IModel
    {
        TKey Id { get; set; }
    }
}
