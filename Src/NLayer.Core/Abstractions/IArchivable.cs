using System;
using System.Collections.Generic;
using System.Text;

namespace NLayer.Core.Abstractions
{
    public interface IArchivable
    {
        bool IsArchived { get; set; }
    }
}
