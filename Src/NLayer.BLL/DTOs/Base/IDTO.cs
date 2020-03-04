namespace NLayer.BLL.DTOs.Base
{
    public interface IDTO<TKey>
    {
        public TKey Id { get; set; }
    }
}
