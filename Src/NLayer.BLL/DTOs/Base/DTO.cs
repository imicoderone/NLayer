namespace NLayer.BLL.DTOs.Base
{
    public abstract class DTO<TKey> : IDTO<TKey>
    {
        public TKey Id { get; set; }
    }

    public abstract class DTO : IDTO<string>
    {
        public string Id { get; set; }
    }
}
