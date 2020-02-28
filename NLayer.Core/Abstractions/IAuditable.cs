using System;

namespace NLayer.Core.Abstractions
{
    public interface IAuditable
    {
        string CreatedBy { get; set; }
        
        DateTime CreatedDate { get; set; }

        string ModifiedBy { get; set; }

        DateTime ModifiedDate { get; set; }

        int Version { get; set; }
    }
}
