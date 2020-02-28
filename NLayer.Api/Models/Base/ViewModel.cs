namespace NLayer.Api.Models.Base
{
    public class ViewModel<TKey> : IViewModel<TKey> 
    {
        public TKey Id { get; set; }
    }

    public class ViewModel : IViewModel<string>
    {
        public string Id { get; set; }
    }
}
