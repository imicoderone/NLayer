namespace NLayer.Core.Abstractions.Entity
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
