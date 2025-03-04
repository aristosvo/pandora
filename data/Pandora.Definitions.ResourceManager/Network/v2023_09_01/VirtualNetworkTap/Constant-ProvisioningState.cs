using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.VirtualNetworkTap;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProvisioningStateConstant
{
    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Succeeded")]
    Succeeded,

    [Description("Updating")]
    Updating,
}
