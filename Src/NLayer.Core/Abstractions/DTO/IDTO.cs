namespace NLayer.Core.Abstractions.DTO
{
    public interface IDTO<TKey>
    {
        public TKey Id { get; set; }
    }
}
