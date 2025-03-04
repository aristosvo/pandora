using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.FirewallPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.Integer)]
internal enum FirewallPolicyIDPSSignatureDirectionConstant
{
    [Description("1")]
    One,

    [Description("2")]
    Two,

    [Description("0")]
    Zero,
}
