using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_05_01.VirtualNetworkGateways;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProcessorArchitectureConstant
{
    [Description("Amd64")]
    AmdSixFour,

    [Description("X86")]
    XEightSix,
}
