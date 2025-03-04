using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_05_01.WebApplicationFirewallPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ApplicationGatewayRequestRoutingRuleTypeConstant
{
    [Description("Basic")]
    Basic,

    [Description("PathBasedRouting")]
    PathBasedRouting,
}
