using NLayer.Core.Abstractions;

namespace NLayer.Core.Extensions
{
    public static class IArchivableExtensions
    {
        public static void Archive(this IArchivable obj)
        {
            obj.IsArchived = true;
        }
    }
}
