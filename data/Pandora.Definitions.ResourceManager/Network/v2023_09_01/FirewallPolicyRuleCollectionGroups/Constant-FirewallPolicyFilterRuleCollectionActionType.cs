using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.FirewallPolicyRuleCollectionGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FirewallPolicyFilterRuleCollectionActionTypeConstant
{
    [Description("Allow")]
    Allow,

    [Description("Deny")]
    Deny,
}
