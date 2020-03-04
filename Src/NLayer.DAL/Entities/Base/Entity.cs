namespace NLayer.DAL.Entities.Base
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }

    public abstract class Entity : IEntity<string>
    {
        public string Id { get; set; }
    }
}
