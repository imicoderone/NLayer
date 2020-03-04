using NLayer.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayer.Core.Extensions
{
    public static class IAuditableExtensions
    {
        public static void Created(this IAuditable obj)
        {
            obj.CreatedDate = DateTime.UtcNow;
            obj.ModifiedDate = DateTime.UtcNow;
            obj.Version = 1;
        }

        public static void Modified(this IAuditable obj)
        {
            obj.ModifiedDate = DateTime.UtcNow;
            obj.UpdateVersion();
        }

        public static void UpdateVersion(this IAuditable obj)
        {
            obj.Version++;
        }
    }
}
