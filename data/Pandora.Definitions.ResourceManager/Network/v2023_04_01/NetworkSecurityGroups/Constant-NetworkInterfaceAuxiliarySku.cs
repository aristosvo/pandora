using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.NetworkSecurityGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NetworkInterfaceAuxiliarySkuConstant
{
    [Description("A8")]
    AEight,

    [Description("A4")]
    AFour,

    [Description("A1")]
    AOne,

    [Description("A2")]
    ATwo,

    [Description("None")]
    None,
}
