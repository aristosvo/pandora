using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_05_01.PrivateEndpoints;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NetworkInterfaceNicTypeConstant
{
    [Description("Elastic")]
    Elastic,

    [Description("Standard")]
    Standard,
}
