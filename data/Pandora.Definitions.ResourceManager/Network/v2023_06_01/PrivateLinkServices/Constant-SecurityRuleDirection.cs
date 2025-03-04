using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_06_01.PrivateLinkServices;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SecurityRuleDirectionConstant
{
    [Description("Inbound")]
    Inbound,

    [Description("Outbound")]
    Outbound,
}
