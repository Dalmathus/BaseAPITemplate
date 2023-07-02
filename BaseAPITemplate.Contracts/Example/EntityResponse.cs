using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAPITemplate.Contracts.Example
{
    public record EntityResponse(
        string Name,
        string Description,
        DateTime LastModifiedDateTime);

}
