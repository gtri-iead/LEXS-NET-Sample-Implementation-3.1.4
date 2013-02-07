using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Description;

namespace Thinktecture.Tools.Web.Services.CodeGeneration.Decorators
{
    /// <summary>
    /// This optional interface can be implemented by any code decorator.
    /// </summary>
    public interface IMetadata
    {
        // Property declaration:
        MetadataSet MetadataSet
        {
            set;
        }

    }
}
