using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Storage.v2023_01_01.PrivateEndpointConnections;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PrivateEndpointServiceConnectionStatusConstant
{
    [Description("Approved")]
    Approved,

    [Description("Pending")]
    Pending,

    [Description("Rejected")]
    Rejected,
}
