using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_06_01.VirtualNetworkGatewayConnections;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualNetworkGatewayConnectionStatusConstant
{
    [Description("Connected")]
    Connected,

    [Description("Connecting")]
    Connecting,

    [Description("NotConnected")]
    NotConnected,

    [Description("Unknown")]
    Unknown,
}
